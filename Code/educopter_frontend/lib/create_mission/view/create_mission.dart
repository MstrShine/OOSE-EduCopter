import 'package:educopter_frontend/create_mission/model/dummy_data.dart';
import 'package:educopter_frontend/create_mission/model/mission.dart';
import 'package:educopter_frontend/create_mission/model/mission_criteria.dart';
import 'package:educopter_frontend/create_mission/services/city_selection_handler.dart';
import 'package:educopter_frontend/create_mission/services/create_filter.dart';
import 'package:educopter_frontend/create_mission/services/get_statenames.dart';
import 'package:educopter_frontend/general/general_widgets/customformfield.dart';
import 'package:educopter_frontend/general/model/city.dart';
import 'package:educopter_frontend/general/services/filter_pattern.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';
import 'package:flutter/material.dart';

class MissionCreateScreen extends StatefulWidget {
  const MissionCreateScreen({super.key});

  @override
  State<MissionCreateScreen> createState() => _MissionCreateScreenState();
}

class _MissionCreateScreenState extends State<MissionCreateScreen> {
  GlobalKey<FormState> formKey = GlobalKey();

  final TextEditingController missionNamesController = TextEditingController();
  final TextEditingController missionNamesDisplayedController =
      TextEditingController();
  final yourScrollController = ScrollController();
  final yourSecondScrollController = ScrollController();

  late List<City> citiesFromMap;
  late List<City> filteredCities;
  late List<City> allCitiesFromMap;
  late List<City> selectedCities;
  late Criteria<City> completeFilter;

  MissionCriteria missionCriteria = MissionCriteria();
  String dropdownvalue = '';
  String dropdownStateValue = "";

  @override
  void initState() {
    super.initState();
    dropdownvalue = availableWorldmaps.first.mapName;
    selectedCities = [];
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(),
      body: SingleChildScrollView(
        child: Center(
          child: ConstrainedBox(
            constraints: BoxConstraints(maxWidth: 1400),
            child: Column(
              children: [
                formSectionWidget(),
                SizedBox(height: 20),
                actionButtons(),
                SizedBox(height: 20),
                Row(
                  children: [
                    SizedBox(width: 10),
                    filteredCitiesWidget(),
                    SizedBox(width: 20),
                    selectedCitiesWidget(),
                    SizedBox(width: 10)
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  Widget formSectionWidget() {
    return Form(
      key: formKey,
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          SizedBox(height: 20),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              SizedBox(width: 10),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Text("Select map"),
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: DropdownButton(
                  value: dropdownvalue,
                  icon: const Icon(Icons.keyboard_arrow_down),
                  items: availableWorldmaps.map((Worldmap map) {
                    return DropdownMenuItem(
                      value: map.mapName,
                      child: Text(map.mapName),
                    );
                  }).toList(),
                  onChanged: (String? selectedValue) {
                    setState(() {
                      dropdownvalue = selectedValue!;
                    });
                  },
                ),
              ),
              SizedBox(width: 10),
              Expanded(
                child: TextField(
                  controller: missionNamesController,
                  decoration: InputDecoration(hintText: "Naam missie"),
                  onChanged: (value) {
                    missionCriteria.setMissionName(value);
                  },
                ),
              ),
              SizedBox(width: 10),
              Expanded(
                child: TextField(
                  controller: missionNamesDisplayedController,
                  decoration:
                      InputDecoration(hintText: "Getoonde naam aan leerlingen"),
                  onChanged: (value) {
                    missionCriteria.setMissionNameDisplayed(value);
                  },
                ),
              ),
              SizedBox(width: 10),
            ],
          ),
          Row(
            children: [
              SizedBox(width: 10),
              FutureBuilder(
                  future: processCsv(context),
                  builder: ((context, snapshot) {
                    if (snapshot.connectionState == ConnectionState.done) {
                      allCitiesFromMap = snapshot.data as List<City>;
                      List<String> stateList = getStatenames(allCitiesFromMap);

                      if (dropdownStateValue.isEmpty) {
                        dropdownStateValue = stateList.first;
                      }

                      return Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: DropdownButton<String>(
                          value: dropdownStateValue,
                          icon: const Icon(Icons.keyboard_arrow_down),
                          items: stateList
                              .map<DropdownMenuItem<String>>((String value) {
                            return DropdownMenuItem(
                              value: value,
                              child: Text(value),
                            );
                          }).toList(),
                          onChanged: (String? selectedValue) {
                            setState(() {
                              dropdownStateValue = selectedValue!;
                              missionCriteria.setStateName(selectedValue);
                            });
                          },
                        ),
                      );
                    } else {
                      return Text("ik ben nog niet klaar");
                    }
                  })),
              SizedBox(width: 10),
              Expanded(
                child: TextField(
                  decoration:
                      InputDecoration(hintText: "Minimum aantal inwoners"),
                  onChanged: (value) {
                    missionCriteria.setMinPopulationFilter(value);
                  },
                ),
              ),
              SizedBox(width: 10),
              Expanded(
                child: TextField(
                  decoration:
                      InputDecoration(hintText: "Maximum aantal inwoners"),
                  onChanged: (value) {
                    missionCriteria.setMaxPopulationFilter(value);
                  },
                ),
              ),

              //Onderstaande knop en functionaliteit voor specifieke missies, not niet geimplementeerd
              // Flexible(
              //   child: CheckboxListTile(
              //       controlAffinity: ListTileControlAffinity.leading,
              //       title: Text('Statische route?'),
              //       value: missionCriteria.fixedRoute,
              //       onChanged: (bool? value) {
              //         setState(() {
              //           missionCriteria.fixedRoute = value!;
              //         });
              //       }),
              // ),

              Flexible(
                child: CheckboxListTile(
                    controlAffinity: ListTileControlAffinity.leading,
                    title: Text('Alleen hoofdsteden'),
                    value: missionCriteria.countryCapitalFilter,
                    onChanged: (bool? value) {
                      setState(() {
                        missionCriteria.countryCapitalFilter = value!;
                      });
                    }),
              ),
              Flexible(
                child: CheckboxListTile(
                    controlAffinity: ListTileControlAffinity.leading,
                    title: Text('Alleen provincie-hoofdsteden'),
                    value: missionCriteria.stateCapitalFilter,
                    onChanged: (bool? value) {
                      setState(() {
                        missionCriteria.stateCapitalFilter = value!;
                      });
                    }),
              ),
              ConstrainedBox(
                constraints: BoxConstraints(maxWidth: 150),
                child: CustomFormField(
                    numOnly: true,
                    labelText: 'Aantal Steden',
                    saveValue: missionCriteria.setDestinationCount),
              ),
              SizedBox(width: 10),
            ],
          ),
        ],
      ),
    );
  }

  Widget actionButtons() {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      children: [
        ElevatedButton(
          onPressed: () {
            completeFilter = CombinedCriteria(
                criteriaList:
                    createCityFilter(missionCriteria, selectedCities));
            setState(() {
              filteredCities = completeFilter.meetCriteria(allCitiesFromMap);
            });
          },
          child: Text('Filter steden'),
        ),
        ElevatedButton(
          onPressed: () {
            addAllFilteredCities(filteredCities, selectedCities);
            setState(() {});
          },
          child: Text("Voeg alle steden toe"),
        ),
        ElevatedButton(
          onPressed: () {
            clearSelection(selectedCities);
            setState(() {});
          },
          child: Text("Wis lijst geselecteerd steden"),
        ),
        ElevatedButton(
          onPressed: () async {
            Mission newMission = Mission(
                missionName: missionCriteria.missionName,
                missionNameDisplayed: missionCriteria.missionNameDisplayed,
                missionCities: selectedCities);

            var result = await showDialog(
              context: context,
              builder: (context) {
                return newMission.saveMissionDialog(context);
              },
            );
            if (result == true) {
              setState(() {
                clearSelection(selectedCities);
                missionCriteria.resetMissionCriteria();
                missionNamesController.clear();
                missionNamesDisplayedController.clear();
              });
            }
          },
          child: Text("Sla missie op"),
        ),
      ],
    );
  }

  Widget filteredCitiesWidget() {
    return Expanded(
      child: FutureBuilder(
        future: processCsv(context),
        builder: ((context, snapshot) {
          if (snapshot.connectionState == ConnectionState.done) {
            allCitiesFromMap = snapshot.data as List<City>;

            completeFilter = CombinedCriteria(
                criteriaList:
                    createCityFilter(missionCriteria, selectedCities));
            filteredCities = completeFilter.meetCriteria(allCitiesFromMap);

            return ConstrainedBox(
              constraints: BoxConstraints(maxHeight: 600, maxWidth: 1200),
              child: Scrollbar(
                controller: yourScrollController,
                child: ListView.builder(
                  controller: yourScrollController,
                  //itemCount: snapshot.data?.length,
                  itemCount: filteredCities.length,
                  itemBuilder: ((context, index) {
                    return GestureDetector(
                      onTap: () {},
                      child: Container(
                        color: (index % 2 == 0)
                            ? Colors.lightBlueAccent[400]
                            : Colors.lightBlueAccent[200],
                        height: 40,
                        child: Padding(
                          padding: const EdgeInsets.all(4.0),
                          child: Row(
                            children: [
                              //Text(snapshot.data?[index].cityName),
                              Expanded(
                                child: Text(filteredCities[index].cityName),
                              ),
                              SizedBox(width: 10),
                              Expanded(
                                child: Text(filteredCities[index].stateName),
                              ),
                              SizedBox(width: 10),
                              SizedBox(
                                width: 80,
                                child: Text(
                                    filteredCities[index].residents.toString()),
                              ),
                              SizedBox(width: 20),
                              IconButton(
                                  alignment: Alignment.centerRight,
                                  onPressed: () {
                                    addCityToSelection(
                                        index, filteredCities, selectedCities);
                                    setState(() {});
                                  },
                                  icon: Icon(Icons.arrow_circle_right_sharp)),
                              SizedBox(width: 20),
                            ],
                          ),
                        ),
                      ),
                    );
                  }),
                ),
              ),
            );
          } else {
            return Text("Ben nog niet klaar");
          }
        }),
      ),
    );
  }

  Widget selectedCitiesWidget() {
    return Expanded(
      child: Center(
          child: ConstrainedBox(
        constraints: BoxConstraints(maxHeight: 600, maxWidth: 1200),
        child: Scrollbar(
          controller: yourSecondScrollController,
          child: ListView.builder(
            controller: yourSecondScrollController,
            itemCount: selectedCities.length,
            itemBuilder: ((context, index) {
              return GestureDetector(
                onTap: () {},
                child: Container(
                  color: (index % 2 == 0)
                      ? Colors.lightBlueAccent[400]
                      : Colors.lightBlueAccent[200],
                  height: 40,
                  child: Padding(
                    padding: const EdgeInsets.all(4.0),
                    child: Row(
                      children: [
                        //Text(snapshot.data?[index].cityName),
                        Expanded(
                          child: Text(selectedCities[index].cityName),
                        ),
                        SizedBox(width: 10),
                        Expanded(
                          child: Text(selectedCities[index].stateName),
                        ),
                        SizedBox(width: 10),
                        SizedBox(
                          width: 80,
                          child:
                              Text(selectedCities[index].residents.toString()),
                        ),
                        SizedBox(width: 20),
                        IconButton(
                            alignment: Alignment.centerRight,
                            onPressed: () {
                              setState(() {
                                selectedCities.removeAt(index);
                              });
                            },
                            icon: Icon(Icons.delete)),
                        SizedBox(width: 20),
                      ],
                    ),
                  ),
                ),
              );
            }),
          ),
        ),
      )

          //     child: FutureBuilder<Album>(
          //   future: futureAlbum,
          //   builder: (context, snapshot) {
          //     if (snapshot.hasData) {
          //       return Text("Ik print nu: ${snapshot.data!.title}");
          //     } else if (snapshot.hasError) {
          //       return Text('${snapshot.error}');
          //     }

          //     // By default, show a loading spinner.
          //     return const CircularProgressIndicator();
          //   },
          // )

          // child: FutureBuilder(
          //   future: gameMap,
          //   builder: (context, snapshot) {
          //     if (snapshot.connectionState ==
          //         ConnectionState.done) {
          //       if (snapshot.hasData) {
          //         return Text(snapshot.data!.mapName);
          //       } else if (snapshot.hasError) {
          //         return Text('${snapshot.error}');
          //       }
          //     } else {
          //       Text("Waiting");
          //     }
          //     throw {print("error")};
          //   },
          // ),

          ),
    );
  }
}
