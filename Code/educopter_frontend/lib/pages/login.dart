import 'package:flutter/material.dart';

class LoginScreen extends StatelessWidget {
  const LoginScreen({super.key});

  @override
  Widget build(BuildContext context) {
   
    var loginData = LoginData();

    return Scaffold(
        body: Container(
            decoration: const BoxDecoration(
              color: Colors.amber,
              image: DecorationImage(
                image: AssetImage('images/background.jpg'),
                fit: BoxFit.cover,
              ),
            ),
            constraints: const BoxConstraints.expand(),
            child: SafeArea(
                child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: <Widget>[
                loginField(loginData.school, 'naam school'),
                loginField(loginData.login, 'login naam'),
                loginField(loginData.password, 'password'),
              ],
            ))));
  }

  Widget loginField(String input, String helptxt) {
    return Container(
        padding: const EdgeInsets.symmetric(vertical: 10.0, horizontal: 20.0),
        child: TextField(
            style: TextStyle(
              color: Colors.black,
            ),
            decoration: InputDecoration(
              filled: true,
              fillColor: Colors.white,
              hintText: helptxt,
              hintStyle: TextStyle(color: Colors.grey),
              border: OutlineInputBorder(
                borderRadius: BorderRadius.all(
                  Radius.circular(10.0),
                ),
                borderSide: BorderSide.none,
              ),
            ),
            onChanged: (value) {
              input = value;
            }));
  }
}

class LoginData {
  String login;
  String password;
  String school;

  LoginData({this.login = '', this.password = '', this.school = ''});
}
