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
          CreateAvailableWorldmapList(availableWorldmaps: availableWorldmaps),
        ],
      ),
    );
  }
}

class CreateAvailableWorldmapList extends StatefulWidget {
  const CreateAvailableWorldmapList(
      {super.key, required this.availableWorldmaps});

  final List<Worldmap> availableWorldmaps;

  @override
  State<CreateAvailableWorldmapList> createState() =>
      _CreateAvailableWorldmapListState();
}

class _CreateAvailableWorldmapListState
    extends State<CreateAvailableWorldmapList> {
  int selectedIndex = 0;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Container(
          color: Colors.amber,
          alignment: FractionalOffset.center,
          child: Column(
            // ignore: prefer_const_literals_to_create_immutables
            children: [
              Padding(
                padding: const EdgeInsets.fromLTRB(0, 15, 0, 15),
                child: Text('Oneindige speelmodus'),
              ),
              Text(
                  'Bezoek zoveel mogelijk steden voordat je brandstof opraakt!'),
            ],
          ),
        ),
        Row(
          children: [
            Flexible(
              child: Padding(
                padding: const EdgeInsets.fromLTRB(5, 10, 5, 10),
                child: Column(
                  children: [
                    ConstrainedBox(
                      constraints:
                          BoxConstraints(maxWidth: 340, maxHeight: 170),
                      child: Scrollbar(
                        child: ListView.builder(
                          itemCount: widget.availableWorldmaps.length,
                          itemBuilder: ((context, index) {
                            return GestureDetector(
                              onTap: () {
                                selectedIndex = index;
                                setState(() {
                                  selectedIndex = index;
                                });
                                setState(() {
                                  selectedIndex = index;
                                });
                              },
                              child: Container(
                                color: (index % 2 == 0)
                                    ? Colors.lightBlueAccent[400]
                                    : Colors.lightBlueAccent[200],
                                height: 40,
                                child: Padding(
                                  padding: const EdgeInsets.all(4.0),
                                  child: Row(
                                    children: [
                                      Text(widget
                                          .availableWorldmaps[index].mapName),
                                    ],
                                  ),
                                ),
                              ),
                            );
                          }),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
            ),
            Flexible(
              child: Padding(
                padding: const EdgeInsets.fromLTRB(5, 10, 5, 10),
                child: Column(
                  // ignore: prefer_const_literals_to_create_immutables
                  children: [
                    SizedBox(height: 30),
                    Container(
                        color: Colors.blueAccent,
                        child: ConstrainedBox(
                            constraints:
                                BoxConstraints(maxWidth: 340, maxHeight: 170),
                            child: Text(widget.availableWorldmaps[selectedIndex]
                                .mapLocation)))
                  ],
                ),
              ),
            ),
          ],
        ),
      ],
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
                    onPressed: (() {
                      Navigator.of(context)
                          .pushReplacementNamed('/createmission');
                    }),
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

class CreateMissionList extends StatefulWidget {
  const CreateMissionList({
    Key? key,
    required this.availableMissions,
  }) : super(key: key);

  final List<Mission> availableMissions;

  @override
  State<CreateMissionList> createState() => _CreateMissionListState();
}

class _CreateMissionListState extends State<CreateMissionList> {
  int selectedIndex = -1;

  @override
  Widget build(BuildContext context) {
    print('de selectedindex is $selectedIndex');

    return Column(
      children: [
        Container(
          color: Colors.amber,
          alignment: FractionalOffset.center,
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            // ignore: prefer_const_literals_to_create_immutables
            children: [
              Text('Missies'),
              ElevatedButton(
                  onPressed: (() {
                    //start geselecteerde missie
                  }),
                  child: Text('Start missie'))
            ],
          ),
        ),
        ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 340, maxHeight: 170),
          child: Scrollbar(
            child: ListView.builder(
              itemCount: widget.availableMissions.length,
              itemBuilder: ((context, index) {
                return GestureDetector(
                  onTap: () {
                    setState(() {
                      selectedIndex = index;
                      print('ik heb nu de index veranderd naar $selectedIndex');
                    });
                  },
                  child: Container(
                    color: (index == selectedIndex)
                        ? Colors.red
                        : (index % 2 == 0)
                            ? Colors.lightBlueAccent[400]
                            : Colors.lightBlueAccent[200],
                    height: 40,
                    child: Padding(
                      padding: const EdgeInsets.all(4.0),
                      child: Row(
                        children: [
                          Text(widget.availableMissions[index].mapName),
                          SizedBox(width: 10),
                          Text(widget
                              .availableMissions[index].missionDescription),
                          Text(index.toString()),
                        ],
                      ),
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
