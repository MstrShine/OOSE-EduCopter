import 'package:educopter_frontend/general/general_widgets/customformfield.dart';
import 'package:educopter_frontend/login/model/login.dart';
import 'package:educopter_frontend/login/view/login_attempt_dialogbox.dart';
import 'package:flutter/material.dart';

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
        child: Container(
          decoration: BoxDecoration(
              image: DecorationImage(
                  image: AssetImage("BackgroundLogin.png"), fit: BoxFit.cover)),
          child: Center(
            child: ConstrainedBox(
              constraints: BoxConstraints(maxWidth: 1000),
              child: Column(
                children: [
                  SizedBox(height: 40),
                  Text(
                    "Welkom bij EduCopter",
                    style: TextStyle(fontFamily: 'Roboto', fontSize: 60),
                  ),
                  SizedBox(height: 30),
                  Form(
                    key: formKey,
                    child: SafeArea(
                      child: Column(
                        children: [
                          SizedBox(height: 20),
                          CustomFormField(
                              labelText: 'Naam school',
                              saveValue: loginData.setSchool),
                          CustomFormField(
                              labelText: 'Login naam',
                              saveValue: loginData.setLogin),
                          CustomFormField(
                              labelText: 'Password',
                              saveValue: loginData.setPassword),
                        ],
                      ),
                    ),
                  ),
                  SizedBox(height: 20),
                  ElevatedButton(
                    onPressed: () {
                      final form = formKey.currentState!;
                      if (form.validate()) {
                        form.save();
                        loginData.saveTest();
                        loginAttemptDialogBox(loginData, context);
                      }
                    },
                    child: Text('Log in'),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
