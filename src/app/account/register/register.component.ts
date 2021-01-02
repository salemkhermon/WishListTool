import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  submitted = false;
  registerForm: FormGroup;
  
  constructor(private formBuilder: FormBuilder) {
    
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
    // this.registerForm.setValue({email : '@'.concat(companyName)})
    if(! (this.registerForm.get('companyName')?.value === ""))
      this.registerForm.get('email')?.setValue('@'.concat(companyName.toLowerCase().concat('.com')));
    else
      this.registerForm.get('email')?.setValue('');
  }
  onSubmit(){
    this.submitted = true;
  }

  get formControls(){return this.registerForm.controls}
}
