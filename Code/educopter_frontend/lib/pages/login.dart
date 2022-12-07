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
  @override
  Widget build(BuildContext context) {
    GlobalKey<FormState> formKey = GlobalKey();
    final loginData = LoginData();
    final user; 

    return Scaffold(
        body: SafeArea(
            child: Column(children: [
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
          )),
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
          child: Text('Log in'))
    ])));
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
                Navigator.of(context).pushReplacementNamed('/select');
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
  // return Scaffold(
  //     body: Container(
  //         decoration: const BoxDecoration(
  //           color: Colors.amber,
  //           // image: DecorationImage(
  //           //   image: AssetImage('images/background.jpg'),
  //           //   fit: BoxFit.cover,
  //           // ),
  //         ),
  //         constraints: const BoxConstraints.expand(),
  //         child: SafeArea(
  //             child: Column(
  //           mainAxisAlignment: MainAxisAlignment.center,
  //           children: <Widget>[
  //             loginField(loginData.school, 'Wat is de naam van je school?'),
  //             loginField(loginData.login, 'Wat is je loginnaam?'),
  //             loginField(loginData.password, 'Voer je password in'),
  //             ElevatedButton(
  //                 onPressed: () {
  //                   print(loginData.school);
  //                 },
  //                 child: Text('hi'))
  //           ],
  //         ))));
  // }

  // Widget loginField(String input, String helptxt) {
  //   return Container(
  //       padding: const EdgeInsets.symmetric(vertical: 10.0, horizontal: 20.0),
  //       child: TextField(
  //           style: TextStyle(
  //             color: Colors.black,
  //           ),
  //           decoration: InputDecoration(
  //             filled: true,
  //             fillColor: Colors.white,
  //             hintText: helptxt,
  //             hintStyle: TextStyle(color: Colors.grey),
  //             border: OutlineInputBorder(
  //               borderRadius: BorderRadius.all(
  //                 Radius.circular(10.0),
  //               ),
  //               borderSide: BorderSide.none,
  //             ),
  //           ),
  //           onChanged: (value) {
  //             input = value;
  //           }));
  // }

  // Widget customFormField(String value, String labeltext) {
  //   return Padding(
  //     padding: const EdgeInsets.all(20.0),
  //     child: Container(
  //       decoration: BoxDecoration(
  //         color: Colors.grey[200],
  //         borderRadius: BorderRadius.circular(10.0),
  //       ),
  //       child: Padding(
  //         padding: EdgeInsets.fromLTRB(8, 10, 8, 10),
  //         child: TextFormField(
  //           //padding: const EdgeInsets.symmetric(vertical: 10.0, horizontal: 20.0),
  //           decoration: InputDecoration(
  //             labelText: 'Naam school',
  //           ),
  //           validator: (value) {
  //             if (value == null || value.isEmpty) {
  //               return 'Invoer vereist';
  //             } else {}
  //           },
  //           onSaved: (val) => setState(() => value = val.toString()),
  //         ),
  //       ),
  //     ),
  //   );
  // }
// }
