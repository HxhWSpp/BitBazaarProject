import { Component } from '@angular/core';
import { DeveloperDetailModel } from '../models/detail-models/developer-detail.model';
import { ActivatedRoute, Router } from '@angular/router';
import { DeveloperService } from '../services/developer.service';
import { CommonModule } from '@angular/common';
import { AppService } from '../services/app.service';

@Component({
  selector: 'app-developers-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './developers-details.component.html',
  styleUrl: './developers-details.component.css'
})
export class DevelopersDetailsComponent {
  id : number | null = 0;
  developer : DeveloperDetailModel | undefined;

  constructor(private route: ActivatedRoute,private developerService: DeveloperService , private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getDeveloperDetails(this.id);
    });
    
  }
  
  getDeveloperDetails(id :number): void {
    this.developerService.getDeveloperById(id).subscribe(developer => this.developer = developer)
    
  }  

  Details(id:number){
    this.router.navigate([`apps/details/${id}`])
  }
  
}
