class MissionCriteria {
  String missionName = '';
  String missionNameDisplayed = '';
  bool countryCapitalFilter = false;
  bool stateCapitalFilter = false;
  int? minPopulationFilter;
  int? maxPopulationFilter;
  int? destinationCount;
  bool fixedRoute = false;
  String? stateName;

  MissionCriteria({
    this.missionName = "",
    this.missionNameDisplayed = "",
    this.countryCapitalFilter = false,
    this.stateCapitalFilter = false,
    this.fixedRoute = false,
  });

  resetMissionCriteria() {
    missionName = "";
    missionNameDisplayed = "";
    countryCapitalFilter = false;
    stateCapitalFilter = false;
    fixedRoute = false;
    minPopulationFilter = 0;
    stateName = "";
  }

  setStateName(String value) {
    stateName = value;
  }

  setMinPopulationFilter(var value) {
    if (int.tryParse(value) != null) {
      minPopulationFilter = int.tryParse(value)!;
    } else {
      minPopulationFilter = 0;
    }
    //print("ik pas nu de minpopfilter aan");
  }

  setMaxPopulationFilter(var value) {
    if (int.tryParse(value) != null) {
      maxPopulationFilter = int.tryParse(value)!;
    } else {
      maxPopulationFilter = 99999999;
    }
  }

  setMissionName(var value) {
    missionName = value;
  }

  setMissionNameDisplayed(var value) {
    missionNameDisplayed = value;
  }

  setDestinationCount(var value) {
    if (int.tryParse(value) != null) {
      destinationCount = int.tryParse(value)!;
    }
  }
}
