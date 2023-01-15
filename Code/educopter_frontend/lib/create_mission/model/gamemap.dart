class GameMap {
  final String id;
  final String mapName;

  GameMap({required this.id, required this.mapName});

  factory GameMap.fromJson(Map<String, dynamic> json) {
    return GameMap(id: json['Id'], mapName: json['Name']);
  }
}
