import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import{ MatInputModule} from '@angular/material/input'
import{MatFormFieldModule} from '@angular/material/form-field'
import {MatSelectModule} from '@angular/material/select'
import{MatAutocompleteModule} from '@angular/material/autocomplete'





@NgModule({
  declarations: [],
  exports:[
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
   MatAutocompleteModule
   
  ],
  imports: [
    CommonModule
  ]
})
export class MaterialModule { }
