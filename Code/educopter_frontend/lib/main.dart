import 'package:educopter_frontend/review_students/view/review_students.dart';
import 'package:flutter/material.dart';
import 'home/view/home.dart';
import 'login/view/login.dart';
import 'create_mission/view/create_mission.dart';
import 'select_activity/view/select_activity.dart';
import 'game/view/game.dart';

void main() {
  runApp(MaterialApp(
    initialRoute: '/login', 
      routes: {
      '/home': (context) => Home(),
      '/login': (context) => LoginScreen(),
      '/select': (context) => ActivitySelectScreen(),
      '/createmission':(context) => MissionCreateScreen(),
      '/reviewstudents':(context) => ReviewStudents(),
      '/game':(context) => GameScreen()
      }
    )
  );
}
