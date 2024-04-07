import { Component } from '@angular/core';
import {GenreModel} from '../models/genre.model';
import { CommonModule } from '@angular/common';
import { GenreService } from '../services/genre.service';
import { MatButtonModule } from '@angular/material/button';
import { DevelopersComponent } from "../developers/developers.component";




@Component({
    selector: 'app-genres',
    standalone: true,
    templateUrl: './genres.component.html',
    styleUrl: './genres.component.css',
    imports: [CommonModule, MatButtonModule, DevelopersComponent]
})
export class GenresComponent {
  genres : GenreModel[] = [];

  constructor(private genreService: GenreService) { }

  ngOnInit(): void {
    this.getGenres();
  }

  getGenres(): void {
    this.genreService.getGenres()
      .subscribe(genres => this.genres = genres);
  }
}
