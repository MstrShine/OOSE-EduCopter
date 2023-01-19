import 'package:flutter/material.dart';

class TeacherActivityOptions extends StatelessWidget {
  const TeacherActivityOptions(
      {Key? key, required this.userData, required BuildContext context})
      : super(key: key);

  final Map userData;

  @override
  Widget build(BuildContext context) {
    return  (userData['rol'] != 'leerling')
            ? Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: ElevatedButton(
                      onPressed: (() {
                        Navigator.of(context).pushNamed('/createmission');
                      }),
                      child: Text('Create mission'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Text("Selecteer een managementactiviteit...of speel een spelletje"),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: ElevatedButton(
                      onPressed: (() {
                        Navigator.of(context).pushNamed('/reviewstudents');
                      }),
                      child: Text('Review students'),
                    ),
                  ),
                ],
              )
            : SizedBox(height: 20);
  }
}
