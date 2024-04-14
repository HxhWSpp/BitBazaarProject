import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { Router, RouterOutlet } from '@angular/router';
import { UserService } from '../services/user.service';
import { ReloadService } from '../services/reload.service';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { ToastrModule } from 'ngx-toastr';
import { ToastrService } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@Component({
  selector: 'app-wallet',
  standalone: true,
  imports: [MatFormFieldModule , FormsModule , CommonModule , RouterOutlet , MatInputModule , MatButtonModule , ToastrModule],
  templateUrl: './wallet.component.html',
  styleUrl: './wallet.component.css'
})
export class WalletComponent {
  ammount: number = 0;

  /**
   *
   */
  constructor(private userService: UserService , private router : Router , private reloadService : ReloadService , private toastr: ToastrService) {}

  AddFunds(){
    console.log(this.ammount);
    this.userService.AddFunds(this.ammount).subscribe((res: any) => {
      this.reloadService.reloadComponent.emit();
    });
    
  }
    

}
    
  
  

