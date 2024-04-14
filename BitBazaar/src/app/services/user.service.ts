import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { UserCreateModel } from "../models/create-models/user-create.model";
import { UserLoginModel } from "../models/user-login.model";
import { CookieService } from "ngx-cookie-service";
import { JwtHelperService } from '@auth0/angular-jwt'
import { UserModel } from "../models/user.model";
import { Observable } from "rxjs";
import { UserDetailModel } from "../models/detail-models/user.detail.model";
import { AppModel } from "../models/app.model";


@Injectable({
    providedIn: 'root'
  })

export class UserService {
      private apiUrl = 'https://localhost:7110/api/Users';
        private userPayload: any;
      constructor(private http: HttpClient , private cookies: CookieService) {
        this.userPayload = this.decodeToken();
       }

    register(userCreate: UserCreateModel){
        const formData = new FormData();
        formData.append('userName' ,userCreate.userName);
        formData.append('description' , userCreate.description);
        formData.append('profileFile' , userCreate.profileFile);
        formData.append('email', userCreate.email);
        formData.append('password' , userCreate.password);

        return this.http.post<UserCreateModel>(`${this.apiUrl}/Register` , formData);
    }

    login(userLogin: UserLoginModel){

        return this.http.post<UserCreateModel>(`${this.apiUrl}/Login` , userLogin);
    }

    GetById(id: string): Observable<UserDetailModel> {           
        const url = `${this.apiUrl}/Id?id=${id}`;
        return this.http.get<UserDetailModel>(url);   
    }

    AddFunds(ammount: number): Observable<any>{
        const url = `${this.apiUrl}/AddFunds?ammount=${ammount}`;
       
        return this.http.patch<any>(url , ammount);
    }

    Buy(appId: number): Observable<any>{                  
        const url = `${this.apiUrl}/AddToLibrary?appId=${appId}`;
        console.log(url);
        console.log(appId);
        return this.http.patch<any>(url , null);                      
    }

    AddToWishList(appId: number): Observable<any>{                  
        const url = `${this.apiUrl}/AddTowishlist?appId=${appId}`;
        console.log(url);
        console.log(appId);
        return this.http.patch<any>(url , null);                              
    }

    RemoveFromWishList(appId: number): Observable<any>{                  
        const url = `${this.apiUrl}/RemoveFromWishlist?appId=${appId}`;
        console.log(url);
        console.log(appId);
        return this.http.patch<any>(url , null);                              
    }

    GetDetails(id: string): Observable<UserDetailModel> {
        const url = `${this.apiUrl}/Id?id=${id}`;
        return this.http.get<UserDetailModel>(url);   
    }


       
  
    

    logout(){
        this.cookies.delete('token');
    }

    storeToken(tokenValue: string){
        this.cookies.set('token' , tokenValue);
    }

    getToken(){
        return this.cookies.get('token');
    }

    isLoggedIn(){
        const token =  this.cookies.get('token');
        if(token != ''){
            return true;
        }
        else {
            return false;
        }
    }

    decodeToken(){
        const jwtHelper = new JwtHelperService();
        const token = this.getToken()!;
        console.log(jwtHelper.decodeToken(token));
        return jwtHelper.decodeToken(token);
    }

    getUserNameFromToken(){
        if(this.userPayload){         
            return this.userPayload["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];           
        }

    }

    getUserIdFromToken(){
        const payload = this.decodeToken();
        if(payload){
            console.log(payload["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid"])     
            return payload["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid"];       
        }
            

        

    }

    getProfilePictureFromToken(){
        if(this.userPayload){         
            return this.userPayload["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri"];           
        }
    }
}