import 'package:educopter_frontend/select_activity/model/mission.dart';
import 'package:flutter/material.dart';

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
            children: [
              Text('Missies'),
              ElevatedButton(
                  onPressed: (() {
                  }),
                  child: Text('Start missie'))
            ],
          ),
        ),
        ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 340, maxHeight: 270),
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
