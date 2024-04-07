import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AppDetailModel } from '../models/detail-models/app-detail.model';
import { AppService } from '../services/app.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-app-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './apps-details.component.html',
  styleUrl: './apps-details.component.css'
})
export class AppsDetailsComponent {
  id : number | null = 0;
  app : AppDetailModel | undefined;

  constructor(private route: ActivatedRoute,private appService: AppService) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getAppDetails(this.id);
    });
  }
  
  getAppDetails(id :number): void {
    this.appService.getAppById(id).subscribe(app => this.app = app)
    console.log(this.app);
  }  
  
}
