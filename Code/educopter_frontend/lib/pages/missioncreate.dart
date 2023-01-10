import 'package:educopter_frontend/helperwidgets/maxcontentwidth.dart';
import 'package:educopter_frontend/model/city.dart';
import 'package:flutter/material.dart';
import 'package:csv/csv.dart';

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
    processCsv(context);
    int selectedIndex = -1;

    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Column(
            children: [
              Form(
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
                              labelText: 'Naam missie',
                              saveValue: setMissionName),
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
                              //Text('Aantal inwoners'),
                              Expanded(
                                  child: CustomFormField(
                                      labelText: 'Minimum aantal inwoners',
                                      saveValue: setMinPopulationFilter)),
                              Expanded(
                                  child: CustomFormField(
                                      labelText: 'Maximum aantal inwoners',
                                      saveValue: setMaxPopulationFilter)),
                              ElevatedButton(
                                onPressed: () {
                                  final form = formKey.currentState!;
                                  if (form.validate()) {
                                    form.save();
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
              FutureBuilder(
                future: processCsv(context),
                builder: ((context, snapshot) {
                  if (snapshot.connectionState == ConnectionState.done) {
                    return ConstrainedBox(
                      constraints:
                          BoxConstraints(maxWidth: 340, maxHeight: 270),
                      child: Scrollbar(
                        child: ListView.builder(
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
                                      Text(snapshot.data?[index].cityName),
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
              )
            ],
          ),
        ),
      ),
    );
  }

  setMinPopulationFilter(var value) {
    minPopulationFilter = value;
  }

  setMaxPopulationFilter(var value) {}

  setMissionName(var value) {
    missionName = value;
  }

  setMissionNameDisplayed(var value) {
    missionNameDisplayed = value;
  }

  setDestinationCount(var value) {
    destinationCount = value;
  }
}
