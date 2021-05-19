import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form-abm',
  templateUrl: './form-abm.component.html',
  styleUrls: ['./form-abm.component.scss']
})
export class FormAbmComponent implements OnInit {

  form: FormGroup;

  constructor(private readonly fb: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      id: [''],
      product: [''], 
      price: ['']
    })
  }

  onSubmit(): void{
    console.log(this.form.value);
  }

}
