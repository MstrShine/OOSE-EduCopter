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
      body:Center(
        child: ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 1400),
          child: Column(
            children: [
              
            ],),
        ),
      )
    );

  }
}