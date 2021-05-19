import { Component } from '@angular/core';
import { ProductServiceService } from './product-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Angular Project';

  public products: Array<any> = []

  constructor(
    private productService:ProductServiceService,
    private router: Router
    ){
    this.productService.getProducts().subscribe((resp: any) =>{
      console.log(resp);
      this.products = resp
    })
  }

  deleteProducts(id){
    this.productService.deleteProduct(id);
  }

}
