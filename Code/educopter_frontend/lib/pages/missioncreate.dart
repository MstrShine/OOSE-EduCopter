import 'package:flutter/material.dart';

import '../helperwidgets/customformfield.dart';

class MissionCreateScreen extends StatefulWidget {
  const MissionCreateScreen({super.key});

  @override
  State<MissionCreateScreen> createState() => _MissionCreateScreenState();
}

class _MissionCreateScreenState extends State<MissionCreateScreen> {
  GlobalKey<FormState> formKey = GlobalKey();

  String missionName = '';
  String missionNameDisplayed = '';

  bool countryCapitolFilter = false;
  bool stateCapitolFilter = false;
  late int minPopulationFilter;
  late int maxPopulationFilter;

  late int destinationCount;

  bool fixedRoute = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Form(
          key: formKey,
          child: Column(
            children: [
              CustomFormField(
                  labelText: 'Naam missie', saveValue: setMissionName),
              CustomFormField(
                  labelText: 'Getoonde naam aan leerlingen',
                  saveValue: setMissionNameDisplayed),
              Row(
                children: [
                  Expanded(
                    child: Padding(
                      padding: const EdgeInsets.all(3.0),
                      child: Container(
                        decoration: BoxDecoration(
                          color: Colors.grey[200],
                          borderRadius: BorderRadius.circular(10.0),
                        ),
                        child: Padding(
                          padding: const EdgeInsets.fromLTRB(8, 10, 8, 8),
                          child: TextFormField(
                            decoration: const InputDecoration(
                                labelText: 'Aantal steden'),
                            onChanged: (String value) {
                              destinationCount = int.parse(value);
                              print(destinationCount.toString());
                            },
                          ),
                        ),
                      ),
                    ),
                  ),
                  Text('Statische route?'),
                  Checkbox(
                      value: fixedRoute,
                      onChanged: (bool? value) {
                        setState(() {
                          fixedRoute = value!;
                        });
                      })
                ],
                //onChanged:
              ),
              Row(
                children: [
                  Row(
                    children: [
                      Text(
                          'Alleen hoofdsteden'),
                      Checkbox(
                          value: countryCapitolFilter,
                          onChanged: (bool? value) {
                            setState(() {
                              countryCapitolFilter = value!;
                            });
                          }),
                    ],
                  ),
                  Row(
                    children: [
                      Text(
                          'Alleen provinciehoofdsteden'),
                      Checkbox(
                          value: stateCapitolFilter,
                          onChanged: (bool? value) {
                            setState(() {
                              stateCapitolFilter = value!;
                            });
                          }),
                    ],
                  )
                ],
                //onChanged:
              ),
            ],
          ),
        ),
      ),
    );
  }

  setMissionName(var value) {
    missionName = value;
  }

  setMissionNameDisplayed(var value) {
    missionNameDisplayed = value;
  }
}
