import 'package:educopter_frontend/general/model/city.dart';

List<String> getStatenames(List<City> citylist) {
  //List<City> cities = citylist;
  List<String> stateNames = [];

  stateNames.add("Alle provincies");

  for (City city in citylist) {
    String stateNameToCheck = city.stateName;
    if (!stateNames.contains(stateNameToCheck)) {
      stateNames.add(city.stateName);
    }
  }
  stateNames.sort();

  return stateNames;
}
