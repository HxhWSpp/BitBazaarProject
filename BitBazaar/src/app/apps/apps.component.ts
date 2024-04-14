import { Component } from '@angular/core';
import { AppModel } from '../models/app.model';
import { AppService } from '../services/app.service';
import { CommonModule } from '@angular/common';
import { Router, RouterOutlet } from '@angular/router';
import {MatGridListModule} from '@angular/material/grid-list';

import { ImageModel } from '../models/image.model';
import { GalleriaModule } from 'primeng/galleria';
@Component({
  selector: 'app-apps',
  standalone: true,
  imports: [CommonModule , RouterOutlet , MatGridListModule],
  templateUrl: './apps.component.html',
  styleUrl: './apps.component.css'
})
export class AppsComponent {  
  apps : AppModel[] = [];

  

  constructor(private appService: AppService , private router: Router) { }

  ngOnInit(): void {
    this.getApps();

  }

  getApps(): void {
    this.appService.getApps()
      .subscribe(apps => {this.apps = apps; console.log(apps)});
  } 

  Details(id:number){
    this.router.navigate([`apps/details/${id}`])
  }
  

  
}
