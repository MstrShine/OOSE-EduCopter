import 'dart:convert';
import 'package:educopter_frontend/create_mission/model/gamemap.dart';
import 'package:http/http.dart' as http;



Future<GameMap> fetchGameMaps() async {
  final response = await http.get(Uri.parse('https://localhost:7223/map'));

  if (response.statusCode == 200) {
    // If the server did return a 200 OK response,
    // then parse the JSON.
    return GameMap.fromJson(jsonDecode(response.body));
  } else {
    // If the server did not return a 200 OK response,
    // then throw an exception.
    throw Exception('Failed to load album');
  }
}
