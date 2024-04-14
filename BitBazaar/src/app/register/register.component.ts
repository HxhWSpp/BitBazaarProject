import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import { UserCreateModel } from '../models/create-models/user-create.model';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Route, Router } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule , CommonModule , MatButtonModule , MatFormFieldModule, MatInputModule, MatSelectModule , MatIconModule , MatFormFieldModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
 
  hide = true;
  userRegister : UserCreateModel = {
    userName: '',
    description: 'hello',
    profilePicture:'',
    profileFile: new File([] , ''),
    email: '',
    password: ''
  }
    constructor(private userService: UserService , private router: Router) {}
 

    onFileChange(event: any): void {
      const file = event.target.files[0];
      this.userRegister.profileFile = file;
    }

    onSubmit(){
      console.log(this.userRegister);
      this.userService.register(this.userRegister).subscribe({
        next:(res => {
          console.log(res);
          this.router.navigate(['/login']);
        })
      });
    }
}
