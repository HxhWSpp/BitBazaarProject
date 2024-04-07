import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GenreModel } from '../models/genre.model';
import { AppCreateModel } from '../models/create-models/app-create.model';
import { GenreDetailModel } from '../models/detail-models/genre-detail.model';
import { map } from 'rxjs/operators';
import { AppModel } from '../models/app.model';

@Injectable({
  providedIn: 'root'
})
export class GenreService {
    private apiUrl = 'https://localhost:7110/api/Genres';
  
    constructor(private http: HttpClient) { }
  
    // CREATE
    createGenre(genre: GenreModel): Observable<GenreModel> {
      return this.http.post<GenreModel>(this.apiUrl, genre);
    }
  
    // READ
    getGenres(): Observable<GenreModel[]> {
      return this.http.get<GenreModel[]>(this.apiUrl);
    }
  
    //GET
    getGenreById(id: number): Observable<GenreModel> {
      const url = `${this.apiUrl}/${id}`;
      return this.http.get<GenreModel>(url);
    }

    //GET
    getGenreDetails(id: number): Observable<GenreDetailModel> {
        const url = `${this.apiUrl}/GetAppsByGenre/${id}`;
        return this.http.get<GenreDetailModel>(url);    
      }
  
    // UPDATE
    updateGenre(genre: GenreModel): Observable<GenreModel> {
      const url = `${this.apiUrl}/${genre.id}`;
      return this.http.put<GenreModel>(url, genre);
    }
  
    // DELETE
    deleteGenre(id: number): Observable<GenreModel> {
      const url = `${this.apiUrl}/${id}`;
      return this.http.delete<GenreModel>(url);
    }

    private mapApiResponseToGenre(apiResponse: any): GenreDetailModel {
        return {
          id: apiResponse.id,
          name: apiResponse.name,
          apps: apiResponse.apps.map((app :AppModel) => ({
            id: app.id,
            title: app.title,
            description: app.description,
            price: app.price,
            titleCardPath: app.titleCardPath,
            releaseDate: app.releaseDate
          }))
        };
    }
}