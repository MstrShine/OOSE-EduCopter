import 'package:educopter_frontend/general/general_widgets/maxcontentwidth.dart';
import 'package:educopter_frontend/select_activity/model/dummy_data.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';
import 'package:educopter_frontend/select_activity/view/available_missions.dart';
import 'package:educopter_frontend/select_activity/view/teacher_activity_options.dart';
import 'package:flutter/material.dart';


class ActivitySelectScreen extends StatefulWidget {
  const ActivitySelectScreen({super.key});

  @override
  State<ActivitySelectScreen> createState() => _ActivitySelectScreenState();
}

class _ActivitySelectScreenState extends State<ActivitySelectScreen> {
  Map userData = {};


  @override
  Widget build(BuildContext context) {
    userData = userData.isNotEmpty
        ? userData
        : ModalRoute.of(context)!.settings.arguments as Map;

    return Scaffold(
      appBar: AppBar(
        title: Text('Welkom ${userData["naam"]}'),
        centerTitle: true,
      ),
      body: Center(
        child: MaxContentWidth(
          widthConstraint: 700,
          childWidget: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              TeacherActivityOptions(userData: userData, context: context),
              CreateMissionList(availableMissions: availableMissions),
              CreateAvailableWorldmapList(
                  availableWorldmaps: availableWorldmaps),
            ],
          ),
        ),
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
                                BoxConstraints(maxWidth: 340, maxHeight: 270),
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
