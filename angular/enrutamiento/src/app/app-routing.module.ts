import { NgModule } from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';
import { MovieDetailComponent } from './movie-detail/movie-detail.component';
import { MovieComponent } from './movie/movie.component';

const rutas: Routes = [
    {path: '', component:HomeComponent},
    {path: 'contacto', component:ContactComponent},
    {path: 'acerca-de', component:AboutComponent},
    {path: 'peliculas', component:MovieComponent},
    {path: 'pelicula-detalle/:id', component:MovieDetailComponent},
];

@NgModule(
    {
        imports: [RouterModule.forRoot(rutas)],
        exports: [RouterModule]

    }
)
export class AppRoutingModule {

}