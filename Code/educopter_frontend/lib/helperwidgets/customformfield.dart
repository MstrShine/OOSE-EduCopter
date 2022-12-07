import 'package:educopter_frontend/model/logindata.dart';
import 'package:flutter/material.dart';
import '../pages/login.dart';
import 'package:flutter/src/widgets/container.dart';
import 'package:flutter/src/widgets/framework.dart';

class CustomFormField extends StatefulWidget {
  final String labelText;
  String loginValue;

  CustomFormField(
      {super.key, required this.labelText, required this.loginValue});

  @override
  State<CustomFormField> createState() => _CustomFormFieldState();
}

class _CustomFormFieldState extends State<CustomFormField> {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(20.0),
      child: Container(
        decoration: BoxDecoration(
          color: Colors.grey[200],
          borderRadius: BorderRadius.circular(10.0),
        ),
        child: Padding(
          padding: EdgeInsets.fromLTRB(8, 10, 8, 10),
          child: TextFormField(
            //padding: const EdgeInsets.symmetric(vertical: 10.0, horizontal: 20.0),
            decoration: InputDecoration(
              labelText: widget.labelText,
            ),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Invoer vereist';
              } else {}
            },
            onSaved: (val) =>
                //setState(() => loginData.setLogin(val.toString()) ),
                setState(() => widget.loginValue = val.toString()),
          ),
        ),
      ),
    );
  }
}
