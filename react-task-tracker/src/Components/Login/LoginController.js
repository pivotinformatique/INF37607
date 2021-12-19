import React from "react";
import { Redirect } from "react-router";
import LoginView from "./LoginView";

class LoginController extends React.Component {
  state = {
    email: "",
    password: "",
    isLogged: false,
  };

  toLogin = async () => {
    var response = await this.props.viewModel.toLogin({
      email: this.state.email,
      password: this.state.password,
    });
    if (response) {
      this.setState({ isLogged: true });
      this.props.viewModel.requestStore.getRequests();
    } else {
      alert("User not found !");
    }
  };

  setEmail = (e) => {
    this.setState({ email: e.target.value });
  };

  setPassword = (e) => {
    this.setState({ password: e.target.value });
  };

  createUser = async () => {
    await this.props.viewModel.createUser();
  };

  render() {
    //const { viewModel } = this.props;
    if (this.state.isLogged) {
      return <Redirect to="/requests" />;
    } else {
      this.createUser(); //to delete later
      return (
        <LoginView
          email={this.state.email}
          password={this.state.password}
          setEmail={this.setEmail}
          setPassword={this.setPassword}
          toLogin={this.toLogin}
        />
      );
    }
  }
}

export default LoginController;
