import 'package:educopter_frontend/general/model/city.dart';

void addCityToSelection(
    int index, List<City> filteredCities, List<City> selectedCities) {
  selectedCities.add(filteredCities[index]);
}

void addAllFilteredCities(
    List<City> filteredCities, List<City> selectedCities) {
  selectedCities.addAll(filteredCities);
}

void clearSelection(List<City> selectedCities) {
  selectedCities.clear();
}
