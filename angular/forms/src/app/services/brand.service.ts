import { Injectable, Inject } from '@angular/core';
import {HttpClient, HttpHeaders, HttpErrorResponse} from '@angular/common/http';
import { catchError, Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BASE_URL } from '../models/constants';

@Injectable({
  providedIn: 'root'
})
export class BrandService {
  //baseUrl = 'https://localhost:44316';
  //baseUrl= environment.baseUrl;
  endpoint:string= '';

  headers= new HttpHeaders().set('Content-Type', 'application/json');

  constructor(private http: HttpClient,
   @Inject(BASE_URL) endpoint:string) { 
    this.endpoint = endpoint;
   }

  getBrands():Observable<any> {
    let apiUrl= `${this.endpoint}/api/Brand`;
    console.log(apiUrl);
    
    return this.http.get(apiUrl);
  }

  createBrand(data: any):Observable<any>{
    let apiUrl= `${this.endpoint}/api/Brand`;
    console.log(apiUrl);
    return this.http.post(apiUrl, data).pipe(catchError(this.error));
  }

  updateBrand(data: any):Observable<any>{
    let apiUrl= `${this.endpoint}/api/Brand`;
    return this.http.put(apiUrl, data).pipe(catchError(this.error));
  }

  error(error: HttpErrorResponse) {
    let errorMessage = '';
    if(error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else  {
      errorMessage = `Codigo error: ${error.status} mensaje: ${error.message}`;
    }

    console.log(errorMessage);
    return throwError(() =>{
      return errorMessage;
    });
  }

}
