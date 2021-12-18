class LoginViewModel {
    constructor(store) {
      this.store = store["user"];
      this.requestStore = store["request"];
    }
  
    getUser() {
      return this.store.getUser();
    }
  
    async toLogin(user) {
      return await this.store.toLogin(user);
    }
  
    async createUser() {
      await this.store.createUser();
    }
  }
  
  export default LoginViewModel;
  