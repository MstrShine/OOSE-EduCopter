import 'package:educopter_frontend/create_mission/model/mission_criteria.dart';
import 'package:educopter_frontend/create_mission/services/city_filter.dart';
import 'package:educopter_frontend/general/model/city.dart';
import 'package:educopter_frontend/general/services/filter_pattern.dart';

List<Criteria<City>> createCityFilter(
    MissionCriteria missionCriteria, List<City> selectedCities) {
  List<Criteria<City>> combinedCriteria = [];

  if (missionCriteria.stateCapitalFilter) {
    Criteria<City> statecapital = CriteriaStateCapital();
    combinedCriteria.add(statecapital);
  }

  if (missionCriteria.countryCapitalFilter) {
    Criteria<City> capital = CriteriaCapital();
    combinedCriteria.add(capital);
  }

  if (missionCriteria.minPopulationFilter != null) {
    int bottomAmmount = missionCriteria.minPopulationFilter!;
    Criteria<City> bottomAmmountResidents =
        CriteriaMinAmmountResidents(bottomAmmountResidents: bottomAmmount);
    combinedCriteria.add(bottomAmmountResidents);
  }

  if (missionCriteria.maxPopulationFilter != null) {
    int upperAmmount = missionCriteria.maxPopulationFilter!;
    Criteria<City> upperAmmountResidents =
        CriteriaMaxAmmountResidents(upperAmmountResidents: upperAmmount);
    combinedCriteria.add(upperAmmountResidents);
  }

  if (selectedCities.isNotEmpty) {
    Criteria<City> notAlreadySelected =
        CriteriaCityNotSelected(selectedCities: selectedCities);
    combinedCriteria.add(notAlreadySelected);
  }

  return combinedCriteria;
}
