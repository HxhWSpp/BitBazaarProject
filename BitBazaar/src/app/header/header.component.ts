import { ChangeDetectorRef, Component } from '@angular/core';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import { CookieService } from 'ngx-cookie-service';
import { UserService } from '../services/user.service';
import { UserStoreService } from '../services/user-store.service';
import {MatMenuModule} from '@angular/material/menu';
import { CommonModule } from '@angular/common';
import { LoadingComponent } from "../loading/loading.component";
import { OnInit } from '@angular/core';
import {MatExpansionModule} from '@angular/material/expansion';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { UserModel } from '../models/user.model';
import { MatFormField, MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';


import { ReloadService } from '../services/reload.service';
import { Subscription } from 'rxjs';
import { HttpClient } from '@angular/common/http';


@Component({
    selector: 'app-header',
    standalone: true,
    templateUrl: './header.component.html',
    styleUrl: './header.component.css',
    imports: [MatToolbarModule, MatIconModule, MatButtonModule, MatMenuModule, CommonModule, LoadingComponent , MatExpansionModule , MatFormFieldModule , MatInputModule , FormsModule ]
})
export class HeaderComponent {
  title = 'BitBazaar';
  userId: string = '';
  user : UserModel | undefined;
  isLoggedIn: boolean = false;
  private sub: Subscription | undefined;
  ammount: number = 0;

  
 
  constructor(private userService: UserService , private userStore : UserStoreService , private router : Router , private reloadService : ReloadService , private cdr: ChangeDetectorRef , private http : HttpClient) {}
 
  
  ngOnInit(){
    this.sub = this.reloadService.reloadComponent.subscribe(() => {
      if(this.userService.isLoggedIn()){
        this.isLoggedIn = true;
        this.userId = this.userService.getUserIdFromToken();    
        this.GetUser(this.userId);  
      }
      else{
        this.isLoggedIn = false;
      }    
    });
    this.userId = this.userService.getUserIdFromToken();
    if(this.userService.isLoggedIn()){
      this.GetUser(this.userId);  
      this.isLoggedIn = true;  
    }
    
  }

  GetUser(id: string){
    console.log(id);
    this.userService.GetById(id).subscribe(user =>{ this.user = user; console.log(user)})
  }

  

  logOut(){
    console.log('logging out')
    this.userService.logout();
    this.reloadService.reloadComponent.emit();
  }

  viewProfile(){
    this.router.navigate(["/users/" + this.userId])
  }

  ngOnDestroy(): void {
    this.sub?.unsubscribe()
  }


  
  
  
  
  
  


  

}
