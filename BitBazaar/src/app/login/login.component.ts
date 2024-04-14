import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import { UserLoginModel } from '../models/user-login.model';
import { CommonModule } from '@angular/common';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { UserStoreService } from '../services/user-store.service';
import { MatFormField, MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIcon, MatIconModule } from '@angular/material/icon';
import { ReloadService } from '../services/reload.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule , FormsModule , MatFormFieldModule , MatInputModule , MatButtonModule , MatIconModule , ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  hide = true;
  userLogin : UserLoginModel = {
    email: '',
    password: ''
  }
   
    constructor(private userService : UserService , private router : Router , private userStore: UserStoreService , private reloader: ReloadService) {}

    onSubmit() {
      console.log(this.userLogin);
      this.userService.login(this.userLogin).subscribe({
        next:(res: any) => {
          this.userService.storeToken(res.token);
          let tokenPayload = this.userService.decodeToken();
          this.userStore.setUserNameForStore(tokenPayload["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]);                
          console.log(tokenPayload);
          this.router.navigate(['/']);
          this.reloader.reloadComponent.emit();
        },       
      })
    }

}
