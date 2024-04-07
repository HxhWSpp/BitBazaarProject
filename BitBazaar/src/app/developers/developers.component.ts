import { Component } from '@angular/core';
import { DeveloperModel } from '../models/developer.model';
import { DeveloperService } from '../services/developer.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-developers',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './developers.component.html',
  styleUrl: './developers.component.css'
})
export class DevelopersComponent {
  developers : DeveloperModel[] = [];

  constructor(private developerService: DeveloperService) { }

  ngOnInit(): void {
    this.getDevelopers();
  }

  getDevelopers(): void {
    this.developerService.getDevelopers()
      .subscribe(developses => this.developers = developses);
  }
}
