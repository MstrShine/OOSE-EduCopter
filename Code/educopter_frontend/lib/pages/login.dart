import 'package:educopter_frontend/pages/missioncreate.dart';
import 'package:flutter/material.dart';
import '../helperwidgets/customformfield.dart';
import '../model/logindata.dart';

class LoginScreen extends StatefulWidget {
  const LoginScreen({super.key});

  @override
  State<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  GlobalKey<FormState> formKey = GlobalKey();
  final loginData = LoginData();

  @override
  Widget build(BuildContext context) {
    //final user;

    return Scaffold(
      body: SafeArea(
        child: Column(
          children: [
            Form(
              key: formKey,
              child: Column(
                children: [
                  CustomFormField(
                      labelText: 'Naam school', saveValue: loginData.setSchool),
                  CustomFormField(
                      labelText: 'Login naam', saveValue: loginData.setLogin),
                  CustomFormField(
                      labelText: 'Password', saveValue: loginData.setPassword),
                ],
              ),
            ),
            ElevatedButton(
              onPressed: () {
                final form = formKey.currentState!;
                if (form.validate()) {
                  form.save();
                  loginData.saveTest();
                  print(loginData.login +
                      ' ' +
                      loginData.school +
                      ' ' +
                      loginData.password);
                  loginHandler(loginData);
                }
              },
              child: Text('Log in'),
            )
          ],
        ),
      ),
    );
  }

  loginHandler(LoginData loginData) {
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
}
