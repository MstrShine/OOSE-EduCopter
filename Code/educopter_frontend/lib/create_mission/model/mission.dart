import 'package:educopter_frontend/general/model/city.dart';
import 'package:flutter/material.dart';

class Mission {
  String missionName;
  String missionNameDisplayed;
  List<City> missionCities;

  Mission(
      {required this.missionName,
      required this.missionNameDisplayed,
      required this.missionCities});

  Widget saveMissionDialog(BuildContext context) {
    if (missionName.isEmpty ||
        missionNameDisplayed.isEmpty ||
        missionCities.isEmpty) {

      return AlertDialog(
        title: const Text("Opslaan mislukt"),
        content: SingleChildScrollView(
          child: ListBody(
            children: const <Widget>[
              Text('Er is iets misgegaan'),
              Text('Controleer of alle relevante gegevens in orde zijn.'),
            ],
          ),
        ),
        actions: <Widget>[
          TextButton(
            child: const Text('Approve'),
            onPressed: () {
              Navigator.of(context).pop(false);
            },
          ),
        ],
      );
    } else {

      return AlertDialog(
        title: const Text("Opslaan gelukt!"),
        content: SingleChildScrollView(
          child: ListBody(
            children: const <Widget>[
              Text('De missie is opgeslagen in de database.'),
              Text('Voeg een volgende missie toe of keer terug naar de homepage.'),
            ],
          ),
        ),
        actions: <Widget>[
          TextButton(
            child: const Text('Approve'),
            onPressed: () {
              Navigator.of(context).pop(true);
            },
          ),
        ],
      );
    }
  }
}
