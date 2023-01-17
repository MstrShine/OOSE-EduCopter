import 'package:educopter_frontend/select_activity/model/mission.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';

final List<Mission> availableMissions = [
  Mission(missionId: 12, mapName: 'Nederland', missionDescription: 'Beginner'),
  Mission(missionId: 13, mapName: 'Nederland', missionDescription: 'Uitdaging'),
  Mission(
      missionId: 14, mapName: 'Duitsland', missionDescription: 'Grote steden'),
  Mission(missionId: 15, mapName: 'Duitsland', missionDescription: 'Uitdaging'),
  Mission(
      missionId: 17,
      mapName: 'Europa',
      missionDescription: 'Speciaal voor jou'),
  Mission(
      missionId: 18,
      mapName: 'Verenigd Koninkrijk',
      missionDescription: 'Beginner'),
  Mission(
      missionId: 19,
      mapName: 'Scandinavië',
      missionDescription: 'Heel erg moeilijk!'),
  Mission(missionId: 20, mapName: 'Afrika', missionDescription: 'Hoofdsteden'),
  Mission(missionId: 12, mapName: 'België', missionDescription: 'Beginner'),
  Mission(missionId: 13, mapName: 'Ijsland', missionDescription: 'Uitdaging'),
  Mission(
      missionId: 14,
      mapName: 'Zwitserland',
      missionDescription: 'Grote steden'),
  Mission(missionId: 15, mapName: 'Polen', missionDescription: 'Uitdaging'),
];

final List<Worldmap> availableWorldmaps = [
  Worldmap(mapId: 1, mapName: 'Nederland', mapLocation: 'Netherlands.png'),
  Worldmap(mapId: 2, mapName: 'Duitsland', mapLocation: 'Duitsland.png'),
  Worldmap(mapId: 3, mapName: 'Europa', mapLocation: 'Europa.png'),
  Worldmap(mapId: 4, mapName: 'Zweden', mapLocation: 'Zweden.png'),
  Worldmap(mapId: 5, mapName: 'Verenigde Staten', mapLocation: 'VS.png'),
  Worldmap(mapId: 6, mapName: 'Ijsland', mapLocation: 'Ijsland.png'),
  Worldmap(mapId: 7, mapName: 'Polen', mapLocation: 'Polen.png'),
  Worldmap(mapId: 8, mapName: 'Verenigd Koninkrijk', mapLocation: 'VK.png'),
  Worldmap(mapId: 9, mapName: 'Noorwegen', mapLocation: 'Noorwegen.png'),
  Worldmap(mapId: 10, mapName: 'België', mapLocation: 'Belgie.png'),
];
