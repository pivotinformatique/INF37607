import React from "react";
import { inject } from "mobx-react";
import LoginController from "./LoginController";
import LoginViewModel from "./LoginViewModel";
import RootStore from "../../models/RootStore";

@inject(RootStore.type.USER_MODEL)
class LoginProvider extends React.Component {
  constructor(props) {
    super(props);
    const loginModel = props[RootStore.type.USER_MODEL];
    this.viewModel = new LoginViewModel(loginModel);
  }

  render() {
    return <LoginController viewModel={this.viewModel} />;
  }
}

export default LoginProvider;
