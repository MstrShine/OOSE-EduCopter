import 'package:educopter_frontend/login/model/login.dart';
import 'package:flutter/material.dart';

loginAttemptDialogBox(LoginData loginData, BuildContext context) {
    if (loginData.attemptLogin(loginData)) {
      return showDialog(
        context: context,
        builder: (context) => AlertDialog(
          title: Text('Inlogpoging succesvol'),
          actions: [
            TextButton(
              child: Text('OK'),
              onPressed: () {
                Navigator.pop(context);
                Map userdata = loginData.getUser();
                Navigator.of(context)
                    .pushReplacementNamed('/select', arguments: userdata);
              },
            )
          ],
        ),
      );
    } else {
      return showDialog(
        context: context,
        builder: (context) => AlertDialog(
          title: Text('Inlogpoging succesvol'),
          actions: [
            TextButton(
              child: Text('OK'),
              onPressed: () {
                Navigator.pop(context);
                Navigator.of(context).pushReplacementNamed('/select');
              },
            )
          ],
        ),
      );
    }
  }