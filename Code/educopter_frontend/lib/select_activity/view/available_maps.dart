import 'package:educopter_frontend/select_activity/model/dummy_data.dart';
import 'package:educopter_frontend/select_activity/model/worldmap.dart';
import 'package:flutter/material.dart';

class AvailableMaps extends StatefulWidget {
  const AvailableMaps({super.key, required this.availableWorldmaps});
  final List<Worldmap> availableWorldmaps;

  @override
  State<AvailableMaps> createState() => _AvailableMapsState();
}

class _AvailableMapsState extends State<AvailableMaps> {
  int selectedIndex = -1;
  final yourScrollController = ScrollController();

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        SizedBox(width: 10),
        Expanded(
          child: ConstrainedBox(
            constraints: BoxConstraints(maxWidth: 340, maxHeight: 200),
            child: Scrollbar(
              controller: yourScrollController,
              child: ListView.builder(
                controller: yourScrollController,
                itemCount: widget.availableWorldmaps.length,
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
                            Text(availableWorldmaps[index].mapName),
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
        SizedBox(width: 20),
        Expanded(
          child: Column(
            // ignore: prefer_const_literals_to_create_immutables
            children: [
              SizedBox(height: 10),
              SizedBox(
                height: 300,
                width: 400,
                child: (selectedIndex != -1)
                    ? Container(
                        decoration: BoxDecoration(
                            image: DecorationImage(
                                image: AssetImage(widget
                                    .availableWorldmaps[selectedIndex]
                                    .mapLocation),
                                fit: BoxFit.scaleDown)),
                      )
                    : Text("Selecteer een kaart"),
              ),
              SizedBox(height: 10)
            ],
          ),
        ),
        SizedBox(width: 20),
        Expanded(
          child: Column(
            children: [
              Text(
                  style: TextStyle(
                      fontSize: 25,
                      color: Colors.blueAccent,
                      fontFamily: 'Comic Sans'),
                  'Mega helicopter adventure time!'),
              SizedBox(height: 20),
              Text(
                  'Bezoek zoveel mogelijk steden voordat je brandstof opraakt.'),
              Text('Probeer een zo hoog mogelijke score te bereiken!'),
              SizedBox(height: 20),
              ElevatedButton(onPressed: (() {}), child: Text('Start missie')),
            ],
          ),
        ),
        SizedBox(width: 10)
      ],
    );
  }
}
