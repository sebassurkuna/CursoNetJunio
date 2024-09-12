import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { environment } from 'src/environments/environment';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrandComponent } from './components/brand/brand.component';
import { BASE_URL } from './models/constants';
import { TempleteFormComponent } from './components/templete-form/templete-form.component';
import { ReactiveFormComponent } from './components/reactive-form/reactive-form.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    BrandComponent,
    TempleteFormComponent,
    ReactiveFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    {
      provide:BASE_URL, useValue:(environment.baseUrl.length > 0 ? environment.baseUrl : 'https://localhost:5000')
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
