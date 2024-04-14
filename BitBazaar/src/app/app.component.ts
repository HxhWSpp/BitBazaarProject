import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {MatButtonModule} from '@angular/material/button';
import { GenresComponent } from "./genres/genres.component";
import { AppsComponent } from "./apps/apps.component";
import { HeaderComponent } from "./header/header.component";
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { GalleriaModule } from 'primeng/galleria';



@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [CommonModule, RouterOutlet, MatButtonModule, GenresComponent, AppsComponent, HeaderComponent , GalleriaModule]
})
export class AppComponent {
 
  
  
}
