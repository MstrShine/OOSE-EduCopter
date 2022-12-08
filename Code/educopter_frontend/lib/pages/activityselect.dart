import 'package:flutter/material.dart';
import '../model/mission.dart';
import '../model/worldmap.dart';

class ActivitySelectScreen extends StatefulWidget {
  const ActivitySelectScreen({super.key});

  @override
  State<ActivitySelectScreen> createState() => _ActivitySelectScreenState();
}

class _ActivitySelectScreenState extends State<ActivitySelectScreen> {
  Map userData = {};

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

  @override
  Widget build(BuildContext context) {
    userData = userData.isNotEmpty
        ? userData
        : ModalRoute.of(context)!.settings.arguments as Map;

    return Scaffold(
      appBar: AppBar(
        title: Text('Welkom ' + userData['naam']),
        centerTitle: true,
      ),
      body: Column(
        children: [
          CreateTeacherOptions(userData: userData),
          CreateMissionList(availableMissions: availableMissions),
        ],
      ),
    );
  }
}

class CreateTeacherOptions extends StatelessWidget {
  const CreateTeacherOptions({
    Key? key,
    required this.userData,
  }) : super(key: key);

  final Map userData;

  @override
  Widget build(BuildContext context) {
    return Container(
        color: Colors.green,
        alignment: FractionalOffset.center,
        child: (userData['rol'] != 'leerling')
            ? Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  ElevatedButton(
                    onPressed: (() {}),
                    child: Text('Create mission'),
                  ),
                  ElevatedButton(
                    onPressed: (() {}),
                    child: Text('Review students'),
                  ),
                ],
              )
            : null);
  }
}

class CreateMissionList extends StatelessWidget {
  const CreateMissionList({
    Key? key,
    required this.availableMissions,
  }) : super(key: key);

  final List<Mission> availableMissions;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Container(
          color: Colors.amber,
          alignment: FractionalOffset.center,
          child: Text('Missies'),
        ),
        ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 340, maxHeight: 170),
          child: Scrollbar(
            child: ListView.builder(
              itemCount: availableMissions.length,
              itemBuilder: ((context, index) {
                return Container(
                  color: (index % 2 == 0)
                      ? Colors.lightBlueAccent[400]
                      : Colors.lightBlueAccent[200],
                  height: 40,
                  child: Padding(
                    padding: const EdgeInsets.all(4.0),
                    child: Row(
                      children: [
                        Text(availableMissions[index].mapName),
                        SizedBox(width: 10),
                        Text(availableMissions[index].missionDescription),
                      ],
                    ),
                  ),
                );
              }),
            ),
          ),
        ),
      ],
    );
  }
}
