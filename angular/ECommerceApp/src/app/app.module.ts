import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrandComponent } from './components/brand/brand.component';
import { ProductComponent } from './components/product/product.component';
import { ProductTypeComponent } from './components/product-type/product-type.component';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { FooterComponent } from './components/footer/footer.component';
import { TestComponent } from './components/test/test.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './components/home/home.component';
import { BASE_URL } from './models/constanst';
import { environment } from 'src/environments/environment';
import { JwtInterceptor } from './interceptors/jwt.interceptor';
import { DefaultErrorComponent } from './components/default-error/default-error.component';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';


@NgModule({
  declarations: [
    AppComponent,
    BrandComponent,
    ProductTypeComponent,
    ProductComponent,
    NavBarComponent,
    FooterComponent,
    TestComponent,
    HomeComponent,
    DefaultErrorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    NgbModule,
    ReactiveFormsModule,
    NgxDatatableModule
  ],
  providers: [
    {
      provide:BASE_URL, useValue:(environment.baseUrl.length > 0 ? environment.baseUrl : 'https://localhost:5000')
    },
    {
      provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true
    },
    {
      provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
