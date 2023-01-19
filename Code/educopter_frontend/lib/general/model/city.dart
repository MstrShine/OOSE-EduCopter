class City {
  String country;
  String cityName;
  String stateName;
  double xCoordCity;
  double yCoordCity;
  int residents;
  bool capital;
  bool stateCapital;

  City(
      {this.country = "Nederland",
      required this.cityName,
      required this.stateName,
      required this.xCoordCity,
      required this.yCoordCity,
      required this.residents,
      this.capital = false,
      this.stateCapital = false});

  factory City.fromJson(Map<String, dynamic> json) {
    return City(
        cityName: json['name'],
        stateName: '',
        xCoordCity: json['x'],
        yCoordCity: json['y'],
        residents: json['population']);
  }
}
