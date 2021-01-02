import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-wish-list',
  templateUrl: './wish-list.component.html',
  styleUrls: ['./wish-list.component.scss']
})
export class WishListComponent implements OnInit {

  wishListForm : FormGroup;
  submitted = false;
  constructor(private formBuilder : FormBuilder) { 
    
    this.wishListForm = this.formBuilder.group({
      previewLinks :['',Validators.required]
    })
  }

  get formControls(){return this.wishListForm.controls}
  
  ngOnInit(): void {
  }

  onSubmit(){
    this.submitted = true;
  }

}
