import { Injectable } from '@angular/core';
import {Account} from '../models/account'

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  isLoggedIn = true;
  constructor() { }

  register(account : Account){
    
  }
  login(email :string, password  :string){
    //localStorage.setItem('user', JSON.stringify(user));
  }

  isUserLoggedIn(){
    return this.isLoggedIn;
  }
  
  logOut(){
    localStorage.removeItem('user');
  }

  isAdminUser(email : string) {
    // query database with this email
}
}
