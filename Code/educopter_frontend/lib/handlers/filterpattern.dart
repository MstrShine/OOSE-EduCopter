import 'package:educopter_frontend/general/model/city.dart';

abstract class Criteria {
  List<City> meetCriteria(List<City> cities);
}

class CriteriaCapital implements Criteria {
  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> capitolCities = [];

    for (City city in cities) {
      if (city.capitol) {
        capitolCities.add(city);
      }
    }

    return capitolCities;
  }
}

class CriteriaStateCapitol implements Criteria {
  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> stateCapitolCities = [];

    for (City city in cities) {
      if (city.capitol) {
        stateCapitolCities.add(city);
      }
    }

    return stateCapitolCities;
  }
}

class CriteriaAmmountResidentsLessThan implements Criteria {
  int upperAmmountResidents;

  CriteriaAmmountResidentsLessThan({this.upperAmmountResidents = 99999999});

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

class CriteriaCityInState implements Criteria {

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

class CriteriaAmmountResidentsMoreThan implements Criteria {
  int bottomAmmountResidents;

  CriteriaAmmountResidentsMoreThan({this.bottomAmmountResidents = 0});

  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> biggerCities = [];

    for (City city in cities) {
      if (city.residents < bottomAmmountResidents) {
        biggerCities.add(city);
      }
    }

    return biggerCities;
  }
}

class CombinedCriteria implements Criteria {
  List<Criteria> criteriaList = [];

  CombinedCriteria({required this.criteriaList});

  @override
  List<City> meetCriteria(List<City> cities) {
    List<City> filteredCities = [];

    for (Criteria criterium in criteriaList) {
      if (filteredCities.isEmpty) {
        filteredCities = criterium.meetCriteria(cities);
      } else {
        filteredCities = criterium.meetCriteria(filteredCities);
      }
    }

    return filteredCities;
  }
}

Criteria capital = CriteriaCapital();
Criteria upperLimitResidents40000 =
    CriteriaAmmountResidentsLessThan(upperAmmountResidents: 40000);

//List<Criteria> combinedCriteria = [capitol, upperLimitResidents40000];
List<Criteria> combinedCriteria = [upperLimitResidents40000];

Criteria completeFilter = CombinedCriteria(criteriaList: combinedCriteria);


//List<City> cityResult = completeFilter.meetCriteria(cities);
