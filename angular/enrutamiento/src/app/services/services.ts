import { Movie } from "../models/models";

export class MovieMockUp {
    movies: Movie[]=  [
        { id: 1, title: 'Godzilla', director: 'Zack Snyder', year: 2020},
        { id: 2, title: 'El Hobbit', director: 'JRR Tolkien', year: 2000},
        { id: 3, title: 'Spiderman', director: 'Sam Reimi', year: 2010},
        { id: 4, title: 'Batman', director: 'JRR Tolkien', year: 2000},
        { id: 5, title: 'Capitan America', director: 'Sam Reimi', year: 2020},
        { id: 6, title: 'John Wick', director: 'Zack Snyder', year: 2010},
      ];


    getAll():Array<Movie> {
        return this.movies;
    }

    getById(id: number):Movie {
        return this.movies[id-1];
    }
}

