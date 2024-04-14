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
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { authGuard } from './guards/auth.guard';
import { WalletComponent } from './wallet/wallet.component';
import { HeaderComponent } from './header/header.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

export const routes: Routes = [
    { path: 'header', component: HeaderComponent },
    { path: 'wallet', component: WalletComponent, canActivate:[authGuard] },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'users/details/:id', component: UserProfileComponent },

    { path: 'genres', component: GenresComponent },
    { path: 'genres/details/:id', component: GenresDetailsComponent },
    { path: 'genres/add', component: GenresAddComponent },
    { path: 'genres/delete/:id', component: GenresDeleteComponent },

    { path: 'apps/add', component: AppsAddComponent },
    { path: 'apps', component: AppsComponent, canActivate:[authGuard] },
    { path: 'apps/details/:id', component: AppsDetailsComponent },
    { path: 'apps/edit/:id' , component: AppsEditComponent},
    { path: 'apps/delete/:id' , component: AppsDeleteComponent},

    { path: 'developers', component: DevelopersComponent },
    { path: 'developers/details/:id', component: DevelopersDetailsComponent },
];
