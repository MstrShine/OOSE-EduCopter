class MissionCriteria {
  String missionName = '';
  String missionNameDisplayed = '';
  bool countryCapitalFilter = false;
  bool stateCapitalFilter = false;
  int? minPopulationFilter;
  int? maxPopulationFilter;
  int? destinationCount;
  bool fixedRoute = false;

  MissionCriteria({
    this.missionName = "",
    this.missionNameDisplayed = "",
    this.countryCapitalFilter = false,
    this.stateCapitalFilter = false,
    this.fixedRoute = false,
  });

  setMinPopulationFilter(var value) {
    if (int.tryParse(value) != null) {
      minPopulationFilter = int.tryParse(value)!;
    }
    //print("ik pas nu de minpopfilter aan");
  }

  setMaxPopulationFilter(var value) {
    if (int.tryParse(value) != null) {
      maxPopulationFilter = int.tryParse(value)!;
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
