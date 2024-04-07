import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router} from '@angular/router';
import { GenreService } from '../services/genre.service';
import { GenreModel } from '../models/genre.model';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-genres-add',
  standalone: true,
  imports: [CommonModule , FormsModule],
  templateUrl: './genres-add.component.html',
  styleUrl: './genres-add.component.css'
})
export class GenresAddComponent {
  genre: GenreModel = {
    id: 0,
    name: ''
  };

  constructor(private genreService: GenreService,
    private router: Router) { }

  createGenre(): void {
    this.genreService.createGenre(this.genre)
      .subscribe(() => {
        this.router.navigate(['/genres'])
      });
  }
}
