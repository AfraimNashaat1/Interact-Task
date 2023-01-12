import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { MatAutocompleteSelectedEvent } from '@angular/material/autocomplete';
import { ProductService } from '../product.service';
import{productDTO} from '../product.model'

@Component({
  selector: 'app-search-product',
  templateUrl: './search-product.component.html',
  styleUrls: ['./search-product.component.css']
})
export class SearchProductComponent implements OnInit {
  
  options :  string[];

  filteredOptions;


  formGroup : FormGroup;
  constructor(private productService: ProductService, private fb : FormBuilder){}
  control: FormControl = new FormControl();
  ngOnInit(){
    this.initForm();
    this.getNames();
  }

  initForm(){
    this.formGroup = this.fb.group({
      'product' : ['']
    })
    this.formGroup.get('product').valueChanges.subscribe(response => {
      console.log('data is ', response);
      this.filterData(response);
    })
  }

  filterData(enteredData){
    debugger;
    this.filteredOptions = this.options.filter(item => {
      return item.toLowerCase().indexOf(enteredData.toLowerCase()) > -1
    });
  }

  getNames(){
    this.productService.getData().subscribe(response => {
      this.options = response;
      this.filteredOptions = response;
    })
  }


//   products:string[]= this.productService.getBySearchItem();
//   originalProducts=this.products;

//   ngOnInit(): void{
//     this.control.valueChanges.subscribe(value=> {
//     this.products = this.originalProducts;
//     this.products=this.products.filter(product=>product.Pname.indexOf(value) !== -1);
//     });



//   }
// optionSelected(event: MatAutocompleteSelectedEvent){
//   debugger;
//   var text= event.option.value.Pname;
//   this.control.patchValue(text);
//   console.log(text);

// }

}
