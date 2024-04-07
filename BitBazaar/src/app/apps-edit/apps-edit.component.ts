import { Component } from '@angular/core';
import { AppModel } from '../models/app.model';
import { ActivatedRoute, Router } from '@angular/router';
import { AppService } from '../services/app.service';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppDetailModel } from '../models/detail-models/app-detail.model';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { AppEditModel } from '../models/edit-models/app-edit.model';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { GenreService } from '../services/genre.service';
import { GenreModel } from '../models/genre.model';
import { DeveloperModel } from '../models/developer.model';

@Component({
  selector: 'app-apps-edit',
  standalone: true,
  imports: [CommonModule, FormsModule ,  MatSelectModule , MatFormFieldModule , ReactiveFormsModule , MatCheckboxModule],
  templateUrl: './apps-edit.component.html',
  styleUrl: './apps-edit.component.css'
})
export class AppsEditComponent {
  genres : GenreModel[] = [];
  selectedGenreIdsToRemove: FormControl = new FormControl<number[]>([]);
  selectedImageIdsToRemove: FormControl = new FormControl<number[]>([]);
  selectedGenreIdsToAdd: FormControl = new FormControl<number[]>([]);
  id : number | null = 0;
  app : AppDetailModel = {
    createdAt: new Date,
    id: 0,
    title: "",
    description: "",
    price: 0,
    titleCardPath: "",
    releaseDate: new Date,
    genres: [],
    images: [],
    
  }

  appEdit : AppEditModel = {
    id: 0,
    title: this.app.title,
    description: this.app.description,
    price: this.app.price,
    releaseDate: this.app.releaseDate,
    genresIdsToAdd: [],
    genresIdsToRemove: [],
    imageIdsToRemove: [],
    imagesToAdd: [],
    createdAt: this.app.createdAt,
    developerId: 0,
    titleCardPath: this.app.titleCardPath,
    titleCardFile:new File([], '')
  };
 

  constructor(private route: ActivatedRoute,private appService: AppService , private genreService: GenreService ,  private router : Router) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getAppDetails(this.id);
      this.getGenres();    
    });
    this.selectedImageIdsToRemove.valueChanges.subscribe((selectedImageIdsToRemove: number[]) => {
      console.log('Selected' , selectedImageIdsToRemove)
    })
  }

  
  
  getAppDetails(id :number): void {
    this.appService.getAppById(id).subscribe(app => this.app = app);   
  }  

  getGenres(): void {
    this.genreService.getGenres()
      .subscribe(genres => this.genres = genres);
  }
 
  onSubmit(){
    this.appEdit.id = this.app.id;
    this.appEdit.title = this.app.title;
    this.appEdit.description = this.app.description;
    this.appEdit.price = this.app.price;
    this.appEdit.createdAt = this.app.createdAt;
    this.appEdit.releaseDate = this.app.releaseDate;
    this.appEdit.titleCardPath = this.app.titleCardPath;
    this.appEdit.genresIdsToRemove = (this.selectedGenreIdsToRemove.value);
    this.appEdit.genresIdsToAdd = (this.selectedGenreIdsToAdd.value);
    this.appEdit.imageIdsToRemove = (this.selectedImageIdsToRemove.value);   


    console.log(this.appEdit);
    this.saveApp();

  }


  onTitleCardChange(event: any): void {
    const file = event.target.files[0];
    this.appEdit.titleCardFile = file;
  }

  onImageFilesChange(event: any){
    this.appEdit.imagesToAdd = event.target.files;
    console.log(this.appEdit.imagesToAdd);
  }

  toggleNumberSelection(number: number): void {
    const selectedNumbersArray = this.selectedImageIdsToRemove.value as number[];
    const index = selectedNumbersArray.indexOf(number);
    if (index === -1) {
      selectedNumbersArray.push(number); // Add the number to the array
    } else {
      selectedNumbersArray.splice(index, 1); // Remove the number from the array
    }
    this.selectedImageIdsToRemove.patchValue(selectedNumbersArray); // Update the form control value
  }

  saveApp() : void {
    this.appService.updateApp(this.appEdit)
    .subscribe(() => {
      this.router.navigate(['/apps'])
    });
  }
 

}
