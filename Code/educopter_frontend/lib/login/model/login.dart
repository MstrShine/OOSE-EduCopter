class LoginData {
  String login;
  String password;
  String school;

  LoginData({this.login = '', this.password = '', this.school = ''});

  bool attemptLogin(LoginData loginData) {
    return true;
  }

  saveTest() {
    //loginHandler('Roos', 'Lanteerne', 'kat123');
    print('ik ben nu data aan het saven');
  }

  void setLogin(String loginnaam) {
    login = loginnaam;
  }

  void setSchool(String schoolnaam) {
    school = schoolnaam;
  }

  void setPassword(String password) {
    this.password = password;
  }

  Map getUser() {
    return {
      'token': 'p@ssword',
      'id': 12345,
      'rol': 'teacher',
      'naam': 'Roos',
      'school': 'Lanteerne'
    };
  }
}
