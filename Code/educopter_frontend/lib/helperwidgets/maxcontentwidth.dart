import 'package:flutter/material.dart';


class MaxContentWidth extends StatelessWidget {
  const MaxContentWidth(
      {super.key, required this.childWidget, required this.widthConstraint});

  final Widget childWidget;
  final double widthConstraint;

  @override
  Widget build(BuildContext context) {
    var media = MediaQuery.of(context);

    double contentWidth =
        media.size.width < widthConstraint ? media.size.width : widthConstraint;

    return SizedBox(
      width: contentWidth,
      child: childWidget,
    );
  }
}
