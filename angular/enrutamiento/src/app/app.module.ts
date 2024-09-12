import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { AboutComponent } from './about/about.component';
import { MovieComponent } from './movie/movie.component';
import { AppRoutingModule } from './app-routing.module';
import { MovieMockUp } from './services/services';
import { MovieDetailComponent } from './movie-detail/movie-detail.component';
//import { RouterModule } from '@angular/router';
//import {Routes, RouterModule} from '@angular/router';


// const rutas: Routes = [
//   {path: '', component:HomeComponent},
//   {path: 'contacto', component:ContactComponent},
//   {path: 'acerca-de', component:AboutComponent},
//   {path: 'peliculas', component:MovieComponent},
// ];


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ContactComponent,
    AboutComponent,
    MovieComponent,
    MovieDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [MovieMockUp],
  bootstrap: [AppComponent]
})
export class AppModule { }
