import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from '../models/models';
import { MovieMockUp } from '../services/services';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.scss']
})
export class MovieDetailComponent implements OnInit {
  identificador: number = 0;
  movie:any;

  constructor(private movieMockUp: MovieMockUp,
    private ruta: ActivatedRoute) { }

  ngOnInit(): void {
    this.ruta.params.subscribe(
      params => {
        this.identificador = params['id'];
        console.log(this.identificador);
        this.movie= this.movieMockUp.getById(this.identificador);
        console.log(this.movie);
      }
    );
  }

}
