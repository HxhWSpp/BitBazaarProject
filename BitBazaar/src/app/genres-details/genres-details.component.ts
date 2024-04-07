import { Component} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GenreService } from '../services/genre.service';
import { GenreDetailModel } from '../models/detail-models/genre-detail.model';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-genres-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './genres-details.component.html',
  styleUrl: './genres-details.component.css'
})
export class GenresDetailsComponent{
  id : number | null = 0;
  genre : GenreDetailModel | undefined;
  
  constructor(private route: ActivatedRoute,private genreService: GenreService) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getGenreDetails(this.id);
    });
  }

  getGenreDetails(id :number): void {
    this.genreService.getGenreDetails(id).subscribe(genre => this.genre = genre)
  }  
}
