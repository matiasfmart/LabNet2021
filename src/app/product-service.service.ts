import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ProductServiceService {
  constructor(private http: HttpClient) {}

  getProducts() {
    let header = new HttpHeaders().set('Type-content', 'aplication/json');
    return this.http.get(environment.products, {
      headers: header,
    });
  }

  deleteProduct(id){
    return this.http.delete(environment.products + id)
  }
}
