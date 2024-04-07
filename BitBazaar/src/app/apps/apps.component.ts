import { Component } from '@angular/core';
import { AppModel } from '../models/app.model';
import { AppService } from '../services/app.service';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-apps',
  standalone: true,
  imports: [CommonModule , RouterOutlet],
  templateUrl: './apps.component.html',
  styleUrl: './apps.component.css'
})
export class AppsComponent {
  apps : AppModel[] = [];

  constructor(private appService: AppService) { }

  ngOnInit(): void {
    this.getApps();
  }

  getApps(): void {
    this.appService.getApps()
      .subscribe(apps => this.apps = apps);
  } 
}
