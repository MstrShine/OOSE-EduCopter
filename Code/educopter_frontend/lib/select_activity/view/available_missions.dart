import 'package:educopter_frontend/select_activity/model/mission.dart';
import 'package:flutter/material.dart';

class AvailableMissions extends StatefulWidget {
  const AvailableMissions({
    Key? key,
    required this.availableMissions,
  }) : super(key: key);

  final List<Mission> availableMissions;

  @override
  State<AvailableMissions> createState() => _AvailableMissionsState();
}

class _AvailableMissionsState extends State<AvailableMissions> {
  int selectedIndex = -1;

  @override
  Widget build(BuildContext context) {
    final yourScrollController = ScrollController();

    return Row(
      children: [
        SizedBox(width: 10),
        Expanded(
          child: Column(
            children: [
              Text('Kies een missie'),
              SizedBox(height: 30),
              Text(
                  "Speel een missie waarbij de route door je leraar is samengesteld en leer spelenderwijs je topografie!"),
              SizedBox(height: 20),
              ElevatedButton(onPressed: (() {}), child: Text('Start missie')),
            ],
          ),
        ),
        SizedBox(width: 20),
        Expanded(
          child: ConstrainedBox(
            constraints: BoxConstraints(maxWidth: 800, maxHeight: 400),
            child: Scrollbar(
              controller: yourScrollController,
              child: ListView.builder(
                controller: yourScrollController,
                itemCount: widget.availableMissions.length,
                itemBuilder: ((context, index) {
                  return GestureDetector(
                    onTap: () {
                      setState(() {
                        selectedIndex = index;
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
                            Expanded(
                                child: Text(
                                    widget.availableMissions[index].mapName)),
                            SizedBox(width: 10),
                            Expanded(
                              child: Text(widget
                                  .availableMissions[index].missionDescription),
                            ),
                          ],
                        ),
                      ),
                    ),
                  );
                }),
              ),
            ),
          ),
        ),
        SizedBox(width: 10)
      ],
    );
  }
}
