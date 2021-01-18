import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable, of} from 'rxjs';
import {catchError, tap} from 'rxjs/operators';
import {Bun} from '../models/Bun';

@Injectable({
  providedIn: 'root'
})
export class BunService {
  private BaseUrl = 'http://localhost:57909/api/Bun';  // URL to web api нужно перенести в env хотя бы
  httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  };

  constructor(
    private http: HttpClient) {
  }
// получить список булок
  getListItems(): Observable<Bun[]> {
    console.log('here');
    return this.http.get<Bun[]>(this.BaseUrl)
      .pipe(
        tap(_ => console.log('fetched heroes')),
        catchError(this.handleError<Bun[]>('getListItems'))
      );
  }

   // эксепшены

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
}
