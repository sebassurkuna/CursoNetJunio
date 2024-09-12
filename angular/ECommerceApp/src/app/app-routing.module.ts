import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrandComponent } from './components/brand/brand.component';
import { DefaultErrorComponent } from './components/default-error/default-error.component';
import { HomeComponent } from './components/home/home.component';
import { ProductTypeComponent } from './components/product-type/product-type.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'brand', component: BrandComponent},
  {path: 'product-type', component: ProductTypeComponent},
  {path: 'not-found', component: DefaultErrorComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
