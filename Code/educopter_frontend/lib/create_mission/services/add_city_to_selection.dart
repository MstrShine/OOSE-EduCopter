import 'package:educopter_frontend/general/model/city.dart';

void addCityToSelection(
    int index, List<City> filteredCities, List<City> selectedCities) {
  selectedCities.add(filteredCities[index]);
  print(selectedCities.toString());
}
