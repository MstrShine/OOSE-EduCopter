class MissionCriteria {
  String missionName = '';
  String missionNameDisplayed = '';
  bool countryCapitolFilter = false;
  bool stateCapitolFilter = false;
  late int minPopulationFilter;
  late int maxPopulationFilter;
  late int destinationCount;
  bool fixedRoute = false;

  MissionCriteria({
    this.missionName = "",
    this.missionNameDisplayed = "",
    this.countryCapitolFilter = false,
    this.stateCapitolFilter = false,
    this.fixedRoute = false,
  });

  setMinPopulationFilter(var value) {
    minPopulationFilter = int.tryParse(value)!;
  }

  setMaxPopulationFilter(var value) {
    maxPopulationFilter = int.tryParse(value)!;
  }

  setMissionName(var value) {
    missionName = value;
  }

  setMissionNameDisplayed(var value) {
    missionNameDisplayed = value;
  }

  setDestinationCount(var value) {
    destinationCount = int.tryParse(value)!;
  }
}
