import { Injectable } from '@angular/core';
import {Account} from '../models/account'
import { HttpClient } from '@angular/common/http';
import { User } from '../models';
import * as forge from 'node-forge';
@Injectable({
  providedIn: 'root'
})
export class LoginService {

  isLoggedIn = true;
  publicKey = `-----BEGIN PUBLIC KEY-----
  MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDstypTHwaGyafew000b0TE2faC
  a6aJUu0/I+l8U20t2amphkMGn9gArl2ck27vBNaCsmi2a4G1B214n9LOThr94u7F
  M+WaUpIKxHMsW5CyP4tOjnOW/PxsJPwQh7WlORj3LMgJ/5PJL8JiFaVDykzOT/Rh
  QNgXG33oKg6BHSOOrwIDAQAB
  -----END PUBLIC KEY-----
  `;
  constructor(private http: HttpClient) { }


  
  login(email :string, password  :string){
    //localStorage.setItem('user', JSON.stringify(user));
    var rsa = forge.pki.publicKeyFromPem(this.publicKey);
    var encryptedPassword = window.btoa(rsa.encrypt(password));
    this.http.post('https://localhost:44349/user/login',new User(email,encryptedPassword)).subscribe(
      res => {
        const token = (<any>res).token;
        localStorage.setItem("jwt", token);
        console.log(token);
      }
    )
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
