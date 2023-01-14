import 'package:educopter_frontend/general/general_widgets/maxcontentwidth.dart';
import 'package:educopter_frontend/login/view/login_attempt_dialogbox.dart';
import 'package:flutter/material.dart';
import '../../general/general_widgets/customformfield.dart';
import '../model/login.dart';

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
        child: Center(
          child: MaxContentWidth(
            widthConstraint: 700,
            childWidget: Column(
              children: [
                Form(
                  key: formKey,
                  child: SafeArea(
                    child: Column(
                      children: [
                        SizedBox(height: 20),
                        CustomFormField(
                            labelText: 'Naam school', saveValue: loginData.setSchool),
                        CustomFormField(
                            labelText: 'Login naam', saveValue: loginData.setLogin),
                        CustomFormField(
                            labelText: 'Password', saveValue: loginData.setPassword),
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
                      print('Ik gebruik nu ${loginData.login} en ${loginData.school} en ${loginData.password}');
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
    );
  }
}
