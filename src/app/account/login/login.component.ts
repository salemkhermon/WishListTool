import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  submitted = false;
  loginForm: FormGroup ;
  constructor(private formBuilder : FormBuilder) {
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
  }

}
