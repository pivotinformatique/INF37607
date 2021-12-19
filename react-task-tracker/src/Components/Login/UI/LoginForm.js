import React from "react";

class LoginForm extends React.Component {
  render() {
    const { email, password, onEmailChange, onPasswordChange, toLogin } =
      this.props;

    return (
      <div className="text-center">
        <form className="loginform modal-body mx-3">
          <h3>Authentification</h3>
          <div className="md-form formInputs">
            <label>Email</label>
            <input
              type="text"
              name="email"
              className="form-control validate"
              value={email}
              onChange={onEmailChange}
            />
          </div>
          <div className="md-form formInputs">
            <label>Mot de passe</label>
            <input
              type="password"
              name="password"
              className="form-control validate"
              value={password}
              onChange={onPasswordChange}
            />
          </div>
          <button type="button" className="btn btn-info" onClick={toLogin}>
            S'authentifier
          </button>
        </form>
      </div>
    );
  }
}

export default LoginForm;
