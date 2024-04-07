import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatSelectModule} from '@angular/material/select';
import {MatFormFieldModule} from '@angular/material/form-field';

import { AppService } from '../services/app.service';
import { AppCreateModel } from '../models/create-models/app-create.model';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { GenreModel } from '../models/genre.model';
import { GenreService } from '../services/genre.service';


@Component({
  selector: 'app-app-add',
  standalone: true,
  imports: [CommonModule , FormsModule , MatSelectModule , MatFormFieldModule , ReactiveFormsModule],
  templateUrl: './apps-add.component.html',
  styleUrl: './apps-add.component.css'
})
export class AppsAddComponent {
  selectedGenreId: FormControl = new FormControl<number[]>([]);
  genres : GenreModel[] = [];
  appForm : AppCreateModel ={
    id: 0 ,
    developerId: 0,
    description: "",
    title: "",
    releaseDate: new Date(),
    createdAt: new Date(),
    price: 0,
    genreIds: [],

    titleCardFile: new File([], ''),
    imageFiles: []

  };

  ngOnInit(): void {
    this.getGenres();
  }

  getGenres(): void {
    this.genreService.getGenres()
      .subscribe(genres => this.genres = genres);
  }

  constructor(private appService: AppService ,private router: Router, private genreService: GenreService ) {}

  onSubmit(): void {   
 
    this.appForm.genreIds = (this.selectedGenreId.value);
    console.log('App:', this.appForm);
    //console.log(this.appForm.imageFiles);

    this.appService.createApp(this.appForm).subscribe(response => {
    this.router.navigate(['/'])
    });

  }
    
  
  onTitleCardChange(event: any): void {
    const file = event.target.files[0];
    this.appForm.titleCardFile = file;
  }

  onImageFilesChange(event: any){
    this.appForm.imageFiles = event.target.files;
    console.log(this.appForm.imageFiles);
  }

  

  
}

