import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from '../../services/login.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  submitted = false;
  loginForm: FormGroup ;
  constructor(private formBuilder : FormBuilder, private loginService : LoginService) {
    this.loginForm = this.formBuilder.group({
      username: ['',Validators.required],
      password :['',[Validators.required,Validators.minLength(6)]]
    }
    )
   }

  get formControls(){return this.loginForm.controls}
  
  ngOnInit(): void {

  }
  
  onSubmit(){
    this.submitted = true;
    var controls = this.formControls;
    this.loginService.login(controls['username'].value,controls['password'].value);
  }

}
