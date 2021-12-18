import React from "react";
import LoginForm from "./UI/LoginForm";

class LoginView extends React.Component {
  render() {
    const { email, password, setEmail, setPassword, toLogin } = this.props;

    return (
      <React.Fragment>
        <LoginForm
          email={email}
          password={password}
          toLogin={toLogin}
          onEmailChange={setEmail}
          onPasswordChange={setPassword}
        />
      </React.Fragment>
    );
  }
}

export default LoginView;
