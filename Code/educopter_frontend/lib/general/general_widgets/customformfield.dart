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
            decoration: InputDecoration(
              labelText: widget.labelText,
            ),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Invoer vereist';
              } else if (widget.numOnly) {
                if (int.tryParse(value) == null) {
                  return 'Alleen cijfers';
                }
              }
              return null;
            },
            onSaved: (val) => widget.saveValue(val),
          ),
        ),
      ),
    );
  }
}
