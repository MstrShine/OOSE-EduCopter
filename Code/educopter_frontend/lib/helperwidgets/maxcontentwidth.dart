import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/container.dart';
import 'package:flutter/src/widgets/framework.dart';

class MaxContentWidth extends StatelessWidget {
  MaxContentWidth(
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
