class LoginData {
  String login;
  String password;
  String school;

  LoginData({this.login = '', this.password = '', this.school = ''});

  attemptLogin(LoginData loginData) {}

  saveTest() {
    //loginHandler('Roos', 'Lanteerne', 'kat123');
    print('ik ben nu data aan het saven');
  }

  set setLogin(String loginnaam) {
    login = loginnaam;
  }
}
