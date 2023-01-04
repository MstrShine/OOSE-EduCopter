import 'package:educopter_frontend/helperwidgets/maxcontentwidth.dart';
import 'package:flutter/material.dart';

import '../helperwidgets/customformfield.dart';
import '../model/worldmap.dart';

class MissionCreateScreen extends StatefulWidget {
  const MissionCreateScreen({super.key});

  @override
  State<MissionCreateScreen> createState() => _MissionCreateScreenState();
}

class _MissionCreateScreenState extends State<MissionCreateScreen> {
  GlobalKey<FormState> formKey = GlobalKey();

  final List<Worldmap> availableWorldmaps = [
    Worldmap(mapId: 1, mapName: 'Nederland', mapLocation: 'Netherlands.svg'),
    Worldmap(mapId: 2, mapName: 'Duitsland', mapLocation: 'Duitsland.svg'),
    Worldmap(mapId: 3, mapName: 'Europa', mapLocation: 'Europa.svg'),
    Worldmap(mapId: 4, mapName: 'Zweden', mapLocation: 'Zweden.svg'),
    Worldmap(mapId: 5, mapName: 'Verenigde Staten', mapLocation: 'VS.svg'),
  ];
  String dropdownvalue = '';

  String missionName = '';
  String missionNameDisplayed = '';

  bool countryCapitolFilter = false;
  bool stateCapitolFilter = false;
  late int minPopulationFilter;
  late int maxPopulationFilter;

  late int destinationCount;

  bool fixedRoute = false;

@override
  void initState() {
    // TODO: implement initState
    super.initState();
    dropdownvalue = availableWorldmaps.first.mapName;
  }

  @override
  Widget build(BuildContext context) {

    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Form(
            key: formKey,
            child: Center(
              child: MaxContentWidth(
                widthConstraint: 1400,
                childWidget: Wrap(
                  alignment: WrapAlignment.spaceEvenly,
                  children: [
                    ConstrainedBox(
                      constraints: BoxConstraints(maxWidth: 700),
                      child: CustomFormField(
                          labelText: 'Naam missie', saveValue: setMissionName),
                    ),
                    ConstrainedBox(
                      constraints: BoxConstraints(maxWidth: 700),
                      child: CustomFormField(
                          labelText: 'Getoonde naam aan leerlingen',
                          saveValue: setMissionNameDisplayed),
                    ),
                    ConstrainedBox(
                      constraints: BoxConstraints(maxWidth: 200),
                      child: CustomFormField(
                          numOnly: true,
                          labelText: 'Aantal Steden',
                          saveValue: setDestinationCount),
                    ),
                    ConstrainedBox(
                      constraints: BoxConstraints(maxWidth: 300),
                      child: CheckboxListTile(
                          controlAffinity: ListTileControlAffinity.leading,
                          title: Text('Statische route?'),
                          value: fixedRoute,
                          onChanged: (bool? value) {
                            setState(() {
                              fixedRoute = value!;
                            });
                          }),
                    ),
                    ConstrainedBox(
                      constraints: BoxConstraints(maxWidth: 300),
                      child: CheckboxListTile(
                          controlAffinity: ListTileControlAffinity.leading,
                          title: Text('Alleen hoofdsteden'),
                          value: countryCapitolFilter,
                          onChanged: (bool? value) {
                            setState(() {
                              countryCapitolFilter = value!;
                            });
                          }),
                    ),
                    ConstrainedBox(
                      constraints: BoxConstraints(maxWidth: 300),
                      child: CheckboxListTile(
                          controlAffinity: ListTileControlAffinity.leading,
                          title: Text('Alleen provinciehoofdsteden'),
                          value: stateCapitolFilter,
                          onChanged: (bool? value) {
                            setState(() {
                              stateCapitolFilter = value!;
                            });
                          }),
                    ),
                    ConstrainedBox(
                      constraints:
                          BoxConstraints(maxWidth: 1400, minWidth: 500),
                      child: Row(
                        children: [
                          Expanded(
                            child: CustomFormField(
                                numOnly: true,
                                labelText: 'Minimum aantal inwoners',
                                saveValue: setMinPopulationFilter),
                          ),
                          Expanded(
                            child: CustomFormField(
                                numOnly: true,
                                labelText: 'Maximum aantal inwoners',
                                saveValue: setMaxPopulationFilter),
                          ),
                          ElevatedButton(
                            onPressed: () {
                              final form = formKey.currentState!;
                              if (form.validate()) {
                                form.save();
                                print('Formulier gevalideerd ik save');
                              }
                            },
                            child: Text('Filter steden'),
                          ),
                        ],
                      ),
                    ),
                    DropdownButton(
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
                  ],
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }

  setMinPopulationFilter(var value) {
    minPopulationFilter = int.tryParse(value)!;
  }

  setMaxPopulationFilter(var value) {
    maxPopulationFilter = int.tryParse(value)!;
  }

  setMissionName(var value) {
    missionName = value;
  }

  setMissionNameDisplayed(var value) {
    missionNameDisplayed = value;
  }

  setDestinationCount(var value) {
    destinationCount = int.tryParse(value)!;
  }
}
