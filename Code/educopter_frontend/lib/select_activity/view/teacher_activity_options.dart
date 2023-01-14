import 'package:flutter/material.dart';

class TeacherActivityOptions extends StatelessWidget {
  const TeacherActivityOptions({
    Key? key,
    required this.userData,
    required BuildContext context 
  }) : super(key: key);

  final Map userData;

  @override
  Widget build(BuildContext context) {
    return Container(
        color: Colors.amber,
        alignment: FractionalOffset.center,
        child: (userData['rol'] != 'leerling')
            ? Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: ElevatedButton(
                      onPressed: (() {
                        Navigator.of(context)
                            .pushReplacementNamed('/createmission');
                      }),
                      child: Text('Create mission'),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: ElevatedButton(
                      onPressed: (() {}),
                      child: Text('Review students'),
                    ),
                  ),
                ],
              )
            : null);
  }
}

