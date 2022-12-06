import 'package:flutter/material.dart';
import '/pages/home.dart';
import 'pages/login.dart';
import 'pages/missioncreate.dart';
import 'pages/activityselect.dart';
import 'pages/game.dart';

void main() {
  runApp(MaterialApp(
    initialRoute: '/login', 
      routes: {
      '/home': (context) => Home(),
      '/login': (context) => LoginScreen(),
      '/select': (context) => ActivitySelectScreen(),
      '/createmission':(context) => MissionCreateScreen(),
      //'/managestudents':(context) => ManageStudentsScreen(),
      '/game':(context) => GameScreen()
      }
    )
  );
}
