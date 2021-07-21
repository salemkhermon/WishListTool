import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Company } from '../models/company';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private http: HttpClient) { }

  registerUser(user : User){
    this.http.post('https://localhost:44349/user/register',user).subscribe(
      res => {
        console.log(res);
      }
    )
  }
  registerCompany(copmany : Company){
    this.http.post('https://localhost:44349/company/register',copmany).subscribe(
      res => {
        console.log(res);
      }
    )
  }
}
