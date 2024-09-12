import { Component, OnInit } from '@angular/core';
import { Movie } from '../models/models';
import { MovieMockUp } from '../services/services';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {
  movies:Array<Movie> = [];
  
  constructor(private movieMockUp: MovieMockUp) { }

  ngOnInit(): void {
    this.movies = this.movieMockUp.getAll();
    console.log(this.movies);
  }

}
