import 'package:educopter_frontend/helperwidgets/maxcontentwidth.dart';
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
                          )
                        ],
                      ),
                    )
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
