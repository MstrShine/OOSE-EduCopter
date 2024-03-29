import 'package:educopter_frontend/select_activity/model/dummy_data.dart';
import 'package:educopter_frontend/select_activity/view/available_maps.dart';
import 'package:educopter_frontend/select_activity/view/available_missions.dart';
import 'package:educopter_frontend/select_activity/view/teacher_activity_options.dart';
import 'package:flutter/material.dart';

class ActivitySelectScreen extends StatefulWidget {
  const ActivitySelectScreen({super.key});

  @override
  State<ActivitySelectScreen> createState() => _ActivitySelectScreenState();
}

class _ActivitySelectScreenState extends State<ActivitySelectScreen> {
  
  Map userData = {};
  
  @override
  Widget build(BuildContext context) {

        userData = userData.isNotEmpty
        ? userData
        : ModalRoute.of(context)!.settings.arguments as Map;

    return Scaffold(
      appBar: AppBar(
        title: Text('Welkom ${userData["naam"]}'),
        centerTitle: true,
      ),
      body: SingleChildScrollView(
        child: Center(
          child: ConstrainedBox(
            constraints: BoxConstraints(maxWidth: 1400),
            child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              SizedBox(height: 10),
              TeacherActivityOptions(userData: userData, context: context),
              SizedBox(height: 20),
              AvailableMissions(availableMissions: availableMissions),
              SizedBox(height: 20),
              AvailableMaps(
                  availableWorldmaps: availableWorldmaps),
            ],
              ),
          ),
        ),
      ),
    );
  }
}

