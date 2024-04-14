import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { UserDetailModel } from '../models/detail-models/user.detail.model';

@Component({
  selector: 'app-user-profile',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
id: string = '';
user: UserDetailModel | undefined
 
  constructor(private route: ActivatedRoute , private userService: UserService , private router: Router) {}
    
    ngOnInit(){
      this.route.params.subscribe(params => {
        this.id = params['id'];
        this.getUserDetails(this.id);
    });
  }
  
  getUserDetails(id: string){
    this.userService.GetById(id).subscribe(user => this.user = user);
  }

  Details(id:number){
    this.router.navigate([`apps/details/${id}`])
  }

}
