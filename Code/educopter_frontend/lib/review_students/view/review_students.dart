import 'package:flutter/material.dart';

class ReviewStudents extends StatefulWidget {
  const ReviewStudents({super.key});

  @override
  State<ReviewStudents> createState() => _ReviewStudentsState();
}

class _ReviewStudentsState extends State<ReviewStudents> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(),
        body: Center(
          child: ConstrainedBox(
            constraints: BoxConstraints(maxWidth: 1400),
            child: Column(
              children: [
                Row(
                  children: [
                    Expanded(
                      flex: 2,
                      child: Column(
                        children: const [
                          Text("test"),
                          Text("test"),
                          Text("test"),
                        ],
                      ),
                    ),
                    Expanded(flex: 1, child: Center(child: Text("test"))),
                    Expanded(flex: 1, child: Center(child: Text("test"))),
                  ],
                ),
                Row(
                  children: const [
                    Expanded(flex: 2, child: Text("test")),
                    Expanded(flex: 2, child: Text("test")),
                  ],
                )
              ],
            ),
          ),
        ));
  }
}
