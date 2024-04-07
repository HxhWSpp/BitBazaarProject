import { Routes } from '@angular/router';
import { GenresComponent } from './genres/genres.component';
import { GenresDetailsComponent } from './genres-details/genres-details.component';
import { GenresAddComponent } from './genres-add/genres-add.component';
import { GenresDeleteComponent } from './genres-delete/genres-delete.component';

import { AppsComponent } from './apps/apps.component';
import { AppsAddComponent } from './apps-add/apps-add.component';

import { AppsEditComponent } from './apps-edit/apps-edit.component';
import { AppsDetailsComponent } from './apps-details/apps-details.component';
import { AppsDeleteComponent } from './apps-delete/apps-delete.component';
import { DevelopersComponent } from './developers/developers.component';
import { DevelopersDetailsComponent } from './developers-details/developers-details.component';

export const routes: Routes = [
    { path: 'genres', component: GenresComponent },
    { path: 'genres/details/:id', component: GenresDetailsComponent },
    { path: 'genres/add', component: GenresAddComponent },
    { path: 'genres/delete/:id', component: GenresDeleteComponent },

    { path: 'apps/add', component: AppsAddComponent },
    { path: 'apps', component: AppsComponent },
    { path: 'apps/details/:id', component: AppsDetailsComponent },
    { path: 'apps/edit/:id' , component: AppsEditComponent},
    { path: 'apps/delete/:id' , component: AppsDeleteComponent},

    { path: 'developers', component: DevelopersComponent },
    { path: 'developers/details/:id', component: DevelopersDetailsComponent },
];
