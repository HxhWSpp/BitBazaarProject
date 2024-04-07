import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AppCreateModel } from '../models/create-models/app-create.model';
import { map } from 'rxjs/operators';
import { AppModel } from '../models/app.model';
import { AppDetailModel } from '../models/detail-models/app-detail.model';
import { AppEditModel } from '../models/edit-models/app-edit.model';


@Injectable({
  providedIn: 'root'
})
export class AppService {
    private apiUrl = 'https://localhost:7110/api/Apps';
  
    constructor(private http: HttpClient) { }
  
    // CREATE
    createApp(appData: AppCreateModel): Observable<AppCreateModel> {
        const formData = new FormData();
    formData.append('title', appData.title);
    formData.append('description', appData.description);
    formData.append('price', appData.price.toString());
    formData.append('releaseDate', appData.releaseDate.toString());
    formData.append('developerId', appData.developerId.toString());
    formData.append('createdAt', appData.createdAt.toISOString());
    formData.append('id', appData.id.toString());

    if (appData.genreIds) {
      appData.genreIds.forEach(genreId => {
        formData.append('genresIdsToAdd', genreId.toString());
      });
    }

    formData.append('titleCardFile', appData.titleCardFile);

    
    if (appData.titleCardPath) {
      formData.append('titleCardPath', appData.titleCardPath);     
    }

   
    for(let i = 0; i < appData.imageFiles.length; i++){
      formData.append('imageFiles' , appData.imageFiles[i]);
    }
 
    
    return this.http.post<AppCreateModel>(this.apiUrl, formData);
    }
  
    // READ
    getApps(): Observable<AppModel[]> {
      return this.http.get<AppModel[]>(this.apiUrl);
    }
  
    //GET
    getAppById(id: number): Observable<AppDetailModel> {
      const url = `${this.apiUrl}/Details/${id}`;
      return this.http.get<AppDetailModel>(url);
    }
 
    // UPDATE
    updateApp(appData: AppEditModel): Observable<AppEditModel> {
      const formData = new FormData();
      formData.append('id', appData.id.toString());
      formData.append('createdAt', appData.createdAt.toString());
      formData.append('title', appData.title);
      formData.append('description' , appData.description);
      formData.append('price' , appData.price.toString());
      formData.append('releaseDate' , appData.releaseDate.toString());
      formData.append('developerId' , appData.developerId.toString());
      
      appData.genresIdsToAdd.forEach(genreId => {
        formData.append('genresIdsToAdd', genreId.toString());
      });

      formData.append('titleCardPath' , appData.titleCardPath);
      formData.append('titleCardFile' , appData.titleCardFile);

      for(let i = 0; i < appData.imagesToAdd.length; i++){
        formData.append('imageFiles' , appData.imagesToAdd[i]);
      }

      appData.genresIdsToRemove.forEach(genreId => {
        formData.append('genresIdsToRemove', genreId.toString());
      });

      appData.imageIdsToRemove.forEach(imageId => {
        formData.append('imageidsToRemove', imageId.toString());
      });
 


      return this.http.put<AppEditModel>(this.apiUrl , formData );
    }
  
    // DELETE
    deleteApp(id: number): Observable<AppModel> {
      const url = `${this.apiUrl}/${id}`;
      return this.http.delete<AppModel>(url);
    }

    
}