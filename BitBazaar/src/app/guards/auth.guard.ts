import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { isPlatformBrowser } from '@angular/common';
import { CookieService } from 'ngx-cookie-service';




export const authGuard: CanActivateFn = (route, state) => {
  
  const userService = inject(UserService);
  const cookie = inject(CookieService);
  const router = inject(Router);
  
    
    if (userService.isLoggedIn()){           
      return true;
    }
    else{
      router.navigate(['/']);
      return false;
    }
  
  
 
      
};
