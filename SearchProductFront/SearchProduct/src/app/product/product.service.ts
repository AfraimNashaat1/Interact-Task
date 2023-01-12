import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { productDTO } from './product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) {
   }
  //  getBySearchItem( itemSearch: string):Observable<productDTO[]>{
  //   return this.http.get<productDTO[]>(`${this.apiURL}/${itemSearch}` );
  //  }

  //private apiURL= environment.apiURLL + '/product';
  private apiURL='https://localhost:44384/api/product'
  
  getData(){
    return this.http.get(this.apiURL)
      .pipe(
        map((response:[]) => response.map(item => item['description']))
      )
  }

}
