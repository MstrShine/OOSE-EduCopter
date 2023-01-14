import 'package:flutter/material.dart';

class CustomFormField extends StatefulWidget {
  final String labelText;
  final Function saveValue;
  final bool numOnly;

  const CustomFormField(
      {super.key,
      required this.labelText,
      required this.saveValue,
      this.numOnly = false});

  @override
  State<CustomFormField> createState() => _CustomFormFieldState();
}

class _CustomFormFieldState extends State<CustomFormField> {
  
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(3.0),
      child: Container(
        decoration: BoxDecoration(
          color: Colors.grey[200],
          borderRadius: BorderRadius.circular(10.0),
        ),
        child: Padding(
          padding: EdgeInsets.fromLTRB(8, 10, 8, 8),
          child: TextFormField(
            //padding: const EdgeInsets.symmetric(vertical: 10.0, horizontal: 20.0),
            decoration: InputDecoration(
              labelText: widget.labelText,
            ),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Invoer vereist';
              } else if (widget.numOnly) {
                //print('check nu of widget numonly is');
                if (int.tryParse(value) == null) {
                  return 'Alleen cijfers';
                }
              } else {
                  //return 'Geen probleem';
              }
            },
            onSaved: (val) =>
                //setState(() => loginData.setLogin(val.toString()) ),
                //setState(() => widget.loginValue = val.toString()),
                widget.saveValue(val),
          ),
        ),
      ),
    );
  }
}
