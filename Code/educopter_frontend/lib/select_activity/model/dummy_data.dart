  import 'package:educopter_frontend/select_activity/model/mission.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';

final List<Mission> availableMissions = [
    Mission(
        missionId: 12, mapName: 'Nederland', missionDescription: 'Inkomertje'),
    Mission(
        missionId: 13, mapName: 'Nederland', missionDescription: 'Uitdaging'),
    Mission(
        missionId: 14, mapName: 'Duitsland', missionDescription: 'Inkomertje'),
    Mission(
        missionId: 15, mapName: 'Duitsland', missionDescription: 'Uitdaging'),
    Mission(
        missionId: 17,
        mapName: 'Europa',
        missionDescription: 'Speciaal voor jou'),
  ];

  final List<Worldmap> availableWorldmaps = [
    Worldmap(mapId: 1, mapName: 'Nederland', mapLocation: 'Netherlands.svg'),
    Worldmap(mapId: 2, mapName: 'Duitsland', mapLocation: 'Duitsland.svg'),
    Worldmap(mapId: 3, mapName: 'Europa', mapLocation: 'Europa.svg'),
    Worldmap(mapId: 4, mapName: 'Zweden', mapLocation: 'Zweden.svg'),
    Worldmap(mapId: 5, mapName: 'Verenigde Staten', mapLocation: 'VS.svg'),
  ];