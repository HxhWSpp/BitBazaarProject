import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { AppCreateModel } from "../models/create-models/app-create.model";
import { CreateReviewModel } from "../models/create-models/review-create.mode";

@Injectable({
    providedIn: 'root'
  })
  export class ReviewService {
      private apiUrl = 'https://localhost:7110/api/Reviews';
    
      constructor(private http: HttpClient) { }
    
      // CREATE
      createReview(review: CreateReviewModel): Observable<CreateReviewModel> {
                 
      return this.http.post<CreateReviewModel>(this.apiUrl, review);
      
      }
    
    }