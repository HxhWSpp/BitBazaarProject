import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { AppModel } from "../models/app.model";
import { AppDetailModel } from "../models/detail-models/app-detail.model";
import { AppEditModel } from "../models/edit-models/app-edit.model";
import { DeveloperCreateModel } from "../models/create-models/developer-create.model";
import { DeveloperModel } from "../models/developer.model";
import { DeveloperDetailModel } from "../models/detail-models/developer-detail.model";

@Injectable({
    providedIn: 'root'
  })
  export class DeveloperService {
      private apiUrl = 'https://localhost:7110/api/Developers';
    
      constructor(private http: HttpClient) { }
    
      // CREATE
      createDeveloper(devData: DeveloperCreateModel): Observable<DeveloperCreateModel> {
          const formData = new FormData();
          formData.append('id' , devData.id.toString());
          formData.append('createdAt' , devData.createdAt.toISOString());
          formData.append('name', devData.name);
          formData.append('description' , devData.description);
          formData.append('profileFile' , devData.profileFile);

          if(devData.profilePath){
            formData.append('profilePath' , devData.profilePath);
          }         

      
      
      return this.http.post<DeveloperCreateModel>(this.apiUrl, formData);
      }
    
      // READ
      getDevelopers(): Observable<DeveloperModel[]> {
        return this.http.get<DeveloperModel[]>(this.apiUrl);
      }
    
      //GET
      getDeveloperById(id: number): Observable<DeveloperDetailModel> {
        const url = `${this.apiUrl}/${id}`;
        return this.http.get<DeveloperDetailModel>(url);
      }
   
      // UPDATE
      updateDeveloper(devData: DeveloperCreateModel): Observable<DeveloperCreateModel> {
        const formData = new FormData();
        formData.append('id' , devData.id.toString());
        formData.append('createdAt' , devData.createdAt.toISOString());
        formData.append('name', devData.name);
        formData.append('description' , devData.description);
        formData.append('profileFile' , devData.profileFile);

        if(devData.profilePath){
          formData.append('profilePath' , devData.profilePath);
        }         

       
        return this.http.put<DeveloperCreateModel>(this.apiUrl , formData );
      }
    
      // DELETE
      deleteDeveloper(id: number): Observable<AppModel> {
        const url = `${this.apiUrl}/${id}`;
        return this.http.delete<AppModel>(url);
      }
  
      
  }