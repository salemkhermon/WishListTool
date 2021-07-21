import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Account, User } from 'src/app/models';
import { Company } from 'src/app/models/company';
import { RegisterService } from 'src/app/services/register.service';
import { LoginService } from '../../services/login.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  submitted = false;
  registerForm: FormGroup;
  
  constructor(private formBuilder: FormBuilder, private loginService :  LoginService, private registerService  :RegisterService) {
    
    this.registerForm = this.formBuilder.group({
      companyName :['',Validators.required],
      email: ['',[Validators.required,Validators.email]],
      password: ['',[Validators.required,Validators.minLength(6)]],
      apiUrl:['',Validators.required],
      apiKey:['',Validators.required]
    })
   }

  ngOnInit(): void {
 
  }

  setEmail(companyName: string){
    var company =this.registerForm.get('companyName')?.value;
    var emailValue =  this.formControls['email'];
    var emailAsString = emailValue.value as string;
    // this.registerForm.setValue({email : '@'.concat(companyName)})
    if(!(company === "")){
      emailValue?.patchValue(emailAsString.substring(0,emailAsString.indexOf('@'))+'@'.concat(companyName.toLowerCase().concat('.com')));
    }
    else
      this.registerForm.get('email')?.setValue('');
  }
  onSubmit(){
    this.submitted = true;
    var controls = this.formControls;
    // this.loginService.register(new Account(controls['email'].value,controls['password'].value,controls['companyName'].value
    //                                       ,controls['apiUrl'].value,controls['apiKey'].value));
    this.registerService.registerCompany(
      new Company(controls['email'].value,controls['password'].value,controls['companyName'].value,controls['apiUrl'].value,controls['apiKey'].value)
      );
                                          
  }

  get formControls(){return this.registerForm.controls}
}
