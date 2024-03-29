import 'package:educopter_frontend/general/services/filter_pattern.dart';
import 'package:educopter_frontend/general/model/city.dart';

class CriteriaCapital implements Criteria<City> {
  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> capitalCities = [];

    for (City city in cities) {
      if (city.capital) {
        capitalCities.add(city);
      }
    }
    return capitalCities;
  }
}

class CriteriaStateCapital implements Criteria<City> {
  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> stateCapitalCities = [];

    for (City city in cities) {
      if (city.capital) {
        stateCapitalCities.add(city);
      }
    }
    return stateCapitalCities;
  }
}

class CriteriaCityInState implements Criteria<City> {
  String stateName;
  CriteriaCityInState({required this.stateName});

  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> citiesInState = [];

    for (City city in cities) {
      if (city.stateName == stateName) {
        citiesInState.add(city);
      }
    }

    return citiesInState;
  }
}

class CriteriaMinAmmountResidents implements Criteria<City> {
  int bottomAmmountResidents;

  CriteriaMinAmmountResidents({this.bottomAmmountResidents = 0});

  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> biggerCities = [];

    for (City city in cities) {
      if (city.residents > bottomAmmountResidents) {
        biggerCities.add(city);
      }
    }

    return biggerCities;
  }
}

class CriteriaMaxAmmountResidents implements Criteria<City> {
  int upperAmmountResidents;

  CriteriaMaxAmmountResidents({this.upperAmmountResidents = 99999999});

  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> smallerCities = [];

    for (City city in cities) {
      if (city.residents < upperAmmountResidents) {
        smallerCities.add(city);
      }
    }
    return smallerCities;
  }
}

class CriteriaCityNotSelected implements Criteria<City> {
  List<City> selectedCities;

  CriteriaCityNotSelected({required this.selectedCities});

  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> filteredCities = List.from(cities);

    if (filteredCities.isNotEmpty) {
      for (int i = (cities.length - 1); i >= 0; i--) {
        for (City selectedCity in selectedCities) {
          if (cities[i].cityName == selectedCity.cityName) {
            filteredCities.removeAt(i);
          }
        }
      }
    }

    return filteredCities;
  }
}


// Criteria<City> capital = CriteriaCapital();
// Criteria<City> upperLimitResidents40000 =
//     CriteriaMaxAmmountResidents(upperAmmountResidents: 40000);

//List<Criteria> combinedCriteria = [capitol, upperLimitResidents40000];
// List<Criteria<City>> combinedCriteria = [upperLimitResidents40000];

// Criteria<City> completeFilter =
//     CombinedCriteria(criteriaList: combinedCriteria);


//List<City> cityResult = completeFilter.meetCriteria(cities);
