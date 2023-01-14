import 'package:csv/csv.dart';
import 'package:educopter_frontend/general/model/city.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';
import 'package:flutter/material.dart';

final List<Worldmap> availableWorldmaps = [
    Worldmap(mapId: 1, mapName: 'Nederland', mapLocation: 'Netherlands.svg'),
    Worldmap(mapId: 2, mapName: 'Duitsland', mapLocation: 'Duitsland.svg'),
    Worldmap(mapId: 3, mapName: 'Europa', mapLocation: 'Europa.svg'),
    Worldmap(mapId: 4, mapName: 'Zweden', mapLocation: 'Zweden.svg'),
    Worldmap(mapId: 5, mapName: 'Verenigde Staten', mapLocation: 'VS.svg'),
  ];

  Future<List> processCsv(context) async {
  var stringResult = await DefaultAssetBundle.of(context).loadString(
    "assets/cities.csv",
  );
  var listResult = CsvToListConverter().convert(stringResult, eol: "\n");

  List<City> cities = [];

  for (int i = 0; i < listResult.length; i++) {
    cities.add(City(
      cityName: listResult[i][0],
      stateName: listResult[i][1],
      xCoordCity: listResult[i][2],
      yCoordCity: listResult[i][3],
      residents: listResult[i][4],
    ));
  }
  return cities;
}