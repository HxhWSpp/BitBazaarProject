import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { GenreService } from '../services/genre.service';
import { ActivatedRoute, Router } from '@angular/router';
import { GenreModel } from '../models/genre.model';

@Component({
  selector: 'app-genres-delete',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './genres-delete.component.html',
  styleUrl: './genres-delete.component.css'
})
export class GenresDeleteComponent {
  id : number | null = 0;
  genre: GenreModel = {id: 0, name: ""};

  constructor(private route: ActivatedRoute, 
    private genreService: GenreService,
    private router : Router) {
    
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.deleteLocation(this.id);
    });
  }

  deleteLocation(id: number): void {
    this.genreService.deleteGenre(id)
      .subscribe(() => {
        this.router.navigate(['/genres'])
      });
  }
}
