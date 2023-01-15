import 'dart:async';
import 'package:educopter_frontend/create_mission/model/album.dart';
import 'package:educopter_frontend/create_mission/model/dummy_data.dart';
import 'package:educopter_frontend/create_mission/model/gamemap.dart';
import 'package:educopter_frontend/create_mission/model/mission_criteria.dart';
import 'package:educopter_frontend/create_mission/services/add_city_to_selection.dart';
import 'package:educopter_frontend/create_mission/services/create_filter.dart';
import 'package:educopter_frontend/create_mission/services/get_album.dart';
import 'package:educopter_frontend/create_mission/services/get_gamemaps.dart';
import 'package:educopter_frontend/general/general_widgets/customformfield.dart';
import 'package:educopter_frontend/create_mission/services/city_filter.dart';
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

  //late Future<GameMap> gameMap;
  //late Future<Album> futureAlbum;

  late List<City> citiesFromMap;
  late List<City> filteredCities;
  late List<City> allCitiesFromMap;
  late List<City> selectedCities;
  late Criteria<City> completeFilter;

  MissionCriteria missionCriteria = MissionCriteria();
  String dropdownvalue = '';

  Timer searchOnStoppedTyping = Timer(Duration(milliseconds: 10), (() {}));

  _onChangedHandler(var value, Function updateValue) {
    const duration = Duration(
        milliseconds:
            1500); // set the duration that you want call search() after that.
    if (searchOnStoppedTyping != null) {
      setState(() => searchOnStoppedTyping.cancel());
    }
    setState(() =>
        searchOnStoppedTyping = Timer(duration, () => updateValue(value)));
  }

  @override
  void initState() {
    super.initState();
    dropdownvalue = availableWorldmaps.first.mapName;
    selectedCities = [];
    //futureAlbum = fetchAlbum();
  }

  // @override
  // void didChangeDependencies() {
  //   super.didChangeDependencies();
  //   gameMap = fetchGameMaps();
  // }

  @override
  Widget build(BuildContext context) {
    processCsv(context);
    int selectedIndex = -1;
    final yourScrollController = ScrollController();
    final yourSecondScrollController = ScrollController();

    return Scaffold(
      appBar: AppBar(),
      body: Center(
        child: ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 1400),
          child: Column(
            children: [
              Form(
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
                        Flexible(
                          child: CustomFormField(
                              labelText: 'Naam missie',
                              saveValue: missionCriteria.setMissionName),
                        ),
                        SizedBox(width: 10),
                        Flexible(
                          child: CustomFormField(
                              labelText: 'Getoonde naam aan leerlingen',
                              saveValue:
                                  missionCriteria.setMissionNameDisplayed),
                        ),
                        SizedBox(width: 10),
                      ],
                    ),
                    Row(
                      children: [
                        SizedBox(width: 10),
                        Expanded(
                          child: TextField(
                            decoration: InputDecoration(
                                hintText: "Minimum aantal inwoners"),
                            onChanged: (value) {
                              missionCriteria.setMinPopulationFilter(value);

                              //onchangedhandler werkt niet, voorlopig via knop filter steden, nog naar kijken

                              // _onChangedHandler(value,
                              //     missionCriteria.setMinPopulationFilter);

                              // setState(() {
                              //   print("nu gaat deze af");
                              // });
                              //print(missionCriteria.minPopulationFilter);
                            },
                          ),
                        ),
                        SizedBox(width: 10),
                        Expanded(
                          child: TextField(
                            decoration: InputDecoration(
                                hintText: "Maximum aantal inwoners"),
                            onChanged: (value) {
                              missionCriteria.setMaxPopulationFilter(value);
                              // _onChangedHandler(value,
                              //     missionCriteria.setMaxPopulationFilter);
                            },
                          ),
                        ),
                        Flexible(
                          child: CheckboxListTile(
                              controlAffinity: ListTileControlAffinity.leading,
                              title: Text('Statische route?'),
                              value: missionCriteria.fixedRoute,
                              onChanged: (bool? value) {
                                setState(() {
                                  missionCriteria.fixedRoute = value!;
                                });
                              }),
                        ),
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
              ),
              SizedBox(height: 20),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  ElevatedButton(
                    //DEZE KNOP WERKT NOG NIET
                    onPressed: () {
                      print("ik wil nu de filter toepassen");
                      completeFilter = CombinedCriteria(
                          criteriaList: createCityFilter(missionCriteria, selectedCities));
                      setState(() {
                        filteredCities =
                            completeFilter.meetCriteria(allCitiesFromMap);
                      });
                    },
                    child: Text('Filter steden'),
                  ),
                  ElevatedButton(
                    onPressed: () {},
                    child: Text("Voeg alle steden toe"),
                  ),
                  ElevatedButton(
                    onPressed: () {},
                    child: Text("Wis lijst geselecteerd steden"),
                  ),
                  ElevatedButton(
                    onPressed: () {},
                    child: Text("Sla missie op"),
                  ),
                ],
              ),
              SizedBox(height: 20),
              Row(
                children: [
                  SizedBox(width: 10),
                  Expanded(
                    child: FutureBuilder(
                      future: processCsv(context),
                      builder: ((context, snapshot) {
                        if (snapshot.connectionState == ConnectionState.done) {
                          allCitiesFromMap = snapshot.data as List<City>;

                          //createFilter(missionCriteria);
                          completeFilter = CombinedCriteria(
                              criteriaList: createCityFilter(missionCriteria, selectedCities));

                          filteredCities =
                              completeFilter.meetCriteria(allCitiesFromMap);
                          //print(filteredCities[5].cityName);
                          // if (missionCriteria.minPopulationFilter != null) {
                          //   print(missionCriteria.minPopulationFilter);
                          // }

                          //Ik wil iets zeggen als...
                          //Criteria totalFilter = createFilter(filterCriteria);
                          //en dan...
                          //List<City> filteredCities =
                          //    totalFilter.meetCriteria(allCitiesFromMap);

                          print("de rebuild van lijst wordt nu getriggered");

                          return ConstrainedBox(
                            constraints:
                                BoxConstraints(maxHeight: 170, maxWidth: 1200),
                            child: Scrollbar(
                              controller: yourScrollController,
                              child: ListView.builder(
                                controller: yourScrollController,
                                //itemCount: snapshot.data?.length,
                                itemCount: filteredCities.length,
                                itemBuilder: ((context, index) {
                                  return GestureDetector(
                                    onTap: () {
                                      //setState(() {});
                                    },
                                    child: Container(
                                      color: (index == selectedIndex)
                                          ? Colors.red
                                          : (index % 2 == 0)
                                              ? Colors.lightBlueAccent[400]
                                              : Colors.lightBlueAccent[200],
                                      height: 40,
                                      child: Padding(
                                        padding: const EdgeInsets.all(4.0),
                                        child: Row(
                                          children: [
                                            //Text(snapshot.data?[index].cityName),
                                            SizedBox(
                                              width: 180,
                                              child: Text(filteredCities[index]
                                                  .cityName),
                                            ),
                                            SizedBox(width: 10),
                                            Text(filteredCities[index]
                                                .residents
                                                .toString()),
                                            SizedBox(width: 40),
                                            IconButton(
                                                alignment:
                                                    Alignment.centerRight,
                                                onPressed: () {
                                                  addCityToSelection(
                                                      index,
                                                      filteredCities,
                                                      selectedCities);
                                                  setState(() {
                                                    
                                                  });
                                                },
                                                icon: Icon(
                                                    Icons.arrow_right_rounded))
                                            //Text(snapshot.data![index].residents
                                            //   .toString()),
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
                  ),
                  SizedBox(width: 20),
                  Expanded(
                    child: Center(
                      child: ConstrainedBox(
                            constraints:
                                BoxConstraints(maxHeight: 170, maxWidth: 1200),
                            child: Scrollbar(
                              controller: yourSecondScrollController,
                              child: ListView.builder(
                                controller: yourSecondScrollController,
                                //itemCount: snapshot.data?.length,
                                itemCount: selectedCities.length,
                                itemBuilder: ((context, index) {
                                  return GestureDetector(
                                    onTap: () {
                                      //setState(() {});
                                    },
                                    child: Container(
                                      color: (index == selectedIndex)
                                          ? Colors.red
                                          : (index % 2 == 0)
                                              ? Colors.lightBlueAccent[400]
                                              : Colors.lightBlueAccent[200],
                                      height: 40,
                                      child: Padding(
                                        padding: const EdgeInsets.all(4.0),
                                        child: Row(
                                          children: [
                                            //Text(snapshot.data?[index].cityName),
                                            SizedBox(
                                              width: 180,
                                              child: Text(selectedCities[index]
                                                  .cityName),
                                            ),
                                            SizedBox(width: 10),
                                            Text(selectedCities[index]
                                                .residents
                                                .toString()),
                                            SizedBox(width: 40),
                                            IconButton(
                                                alignment:
                                                    Alignment.centerRight,
                                                onPressed: () {
                                                  // addCityToSelection(
                                                  //     index,
                                                  //     filteredCities,
                                                  //     selectedCities);
                                                },
                                                icon: Icon(
                                                    Icons.arrow_right_rounded))
                                            //Text(snapshot.data![index].residents
                                            //   .toString()),
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
                  ),
                  // child: Text(
                  //     "Voor test hier komen de geselecteerde steden."))),
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}
