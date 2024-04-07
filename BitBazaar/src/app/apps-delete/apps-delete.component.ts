import { Component } from '@angular/core';
import { AppModel } from '../models/app.model';
import { ActivatedRoute, Router } from '@angular/router';

import { AppService } from '../services/app.service';

@Component({
  selector: 'app-apps-delete',
  standalone: true,
  imports: [],
  templateUrl: './apps-delete.component.html',
  styleUrl: './apps-delete.component.css'
})
export class AppsDeleteComponent {
  id : number | null = 0;
 

  constructor(private route: ActivatedRoute,  private router : Router , private appService: AppService,) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.deleteApp(this.id);
    });
  }

  deleteApp(id: number): void {
    this.appService.deleteApp(id)
      .subscribe(() => {
        this.router.navigate(['/apps'])
      });
  }
}
