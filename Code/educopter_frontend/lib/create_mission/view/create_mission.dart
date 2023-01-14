import 'package:educopter_frontend/create_mission/model/dummy_data.dart';
import 'package:educopter_frontend/create_mission/model/mission_criteria.dart';
import 'package:educopter_frontend/general/general_widgets/customformfield.dart';
import 'package:educopter_frontend/create_mission/services/city_filter.dart';
import 'package:educopter_frontend/general/general_widgets/maxcontentwidth.dart';
import 'package:educopter_frontend/general/model/city.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';
import 'package:flutter/material.dart';

class MissionCreateScreen extends StatefulWidget {
  const MissionCreateScreen({super.key});

  @override
  State<MissionCreateScreen> createState() => _MissionCreateScreenState();
}

class _MissionCreateScreenState extends State<MissionCreateScreen> {
  GlobalKey<FormState> formKey = GlobalKey();

  MissionCriteria missionCriteria = MissionCriteria();

  String dropdownvalue = '';

  @override
  void initState() {
    super.initState();
    dropdownvalue = availableWorldmaps.first.mapName;
  }

  @override
  Widget build(BuildContext context) {
    processCsv(context);
    int selectedIndex = -1;
    final yourScrollController = ScrollController();

    return Scaffold(
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
                          child: CustomFormField(
                              numOnly: true,
                              labelText: 'Minimum aantal inwoners',
                              saveValue:
                                  missionCriteria.setMinPopulationFilter),
                        ),
                        SizedBox(width: 10),
                        Expanded(
                          child: CustomFormField(
                              numOnly: true,
                              labelText: 'Maximum aantal inwoners',
                              saveValue:
                                  missionCriteria.setMaxPopulationFilter),
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
                    Row(
                      children: [
                        // ElevatedButton(
                        //   onPressed: () {
                        //     final form = formKey.currentState!;
                        //     if (form.validate()) {
                        //       form.save();
                        //       print('Formulier gevalideerd ik save');
                        //     }
                        //   },
                        //   child: Text('Filter steden'),
                        // ),
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
                          List<City> allCitiesFromMap =
                              snapshot.data as List<City>;
                          List<City> filteredCities =
                              completeFilter.meetCriteria(allCitiesFromMap);
                          print(filteredCities[5].cityName);

                          //Ik wil iets zeggen als...
                          //Criteria totalFilter = createFilter(filterCriteria);
                          //en dan...
                          //List<City> filteredCities =
                          //    totalFilter.meetCriteria(allCitiesFromMap);

                          return ConstrainedBox(
                            constraints:
                                BoxConstraints(maxHeight: 170, maxWidth: 1200),
                            child: Scrollbar(
                              controller: yourScrollController,
                              child: ListView.builder(
                                controller: yourScrollController,
                                itemCount: snapshot.data?.length,
                                itemBuilder: ((context, index) {
                                  return GestureDetector(
                                    onTap: () {
                                      setState(() {});
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
                                            Text(
                                                snapshot.data?[index].cityName),
                                            SizedBox(width: 10),
                                            Text(snapshot.data![index].residents
                                                .toString()),
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
                          child: Text(
                              "Voor test hier komen de geselecteerde steden."))),
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}
