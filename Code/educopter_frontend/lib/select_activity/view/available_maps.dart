import 'package:educopter_frontend/select_activity/model/worldmap.dart';
import 'package:flutter/material.dart';

class AvailableMaps extends StatefulWidget {
  const AvailableMaps(
      {super.key, required this.availableWorldmaps});

  final List<Worldmap> availableWorldmaps;

  @override
  State<AvailableMaps> createState() =>
      _AvailableMapsState();
}

class _AvailableMapsState
    extends State<AvailableMaps> {
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
