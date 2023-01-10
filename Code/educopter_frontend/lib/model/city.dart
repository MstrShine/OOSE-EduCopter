import 'package:csv/csv.dart';
import 'package:flutter/cupertino.dart';

class City {
  String country;
  String cityName;
  String stateName;
  double xCoordCity;
  double yCoordCity;
  int residents;
  bool capitol;
  bool stateCapitol;

  City(
      {this.country = "Nederland",
      required this.cityName,
      required this.stateName,
      required this.xCoordCity,
      required this.yCoordCity,
      required this.residents,
      this.capitol = false,
      this.stateCapitol = false});
}

//var cityList = convertCitiesToList();

//Future<List<List<dynamic>>> processCsv(context) async {
Future<List> processCsv(context) async {
  var stringResult = await DefaultAssetBundle.of(context).loadString(
    "assets/cities.csv",
  );
  var listResult = CsvToListConverter().convert(stringResult, eol: "\n");
  //print(listResult);
  //return listResult;

  //Map<String, dynamic> cityList = {};
  List cities = [];

  for (int i = 0; i < listResult.length; i++) {
    cities.add(City(
      cityName: listResult[i][0],
      stateName: listResult[i][1],
      xCoordCity: listResult[i][2],
      yCoordCity: listResult[i][3],
      residents: listResult[i][4],
    ));
  }
  print(cities);
  return cities;
}


// List<List<dynamic>> rowsAsListOfValues = const CsvToListConverter().convert(yourString);
// return rowsAsListOfValues;



