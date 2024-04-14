import { CommonModule } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { AppDetailModel } from '../models/detail-models/app-detail.model';
import { AppService } from '../services/app.service';
import { ActivatedRoute } from '@angular/router';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { trigger, transition, animate, style } from '@angular/animations';
import { MatButtonModule } from '@angular/material/button';
import { UserService } from '../services/user.service';
import { UserDetailModel } from '../models/detail-models/user.detail.model';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ReloadService } from '../services/reload.service';
import { Subscription } from 'rxjs';
import {
  MatDialog,
  MAT_DIALOG_DATA,
  MatDialogRef,
  MatDialogTitle,
  MatDialogContent,
  MatDialogActions,
  MatDialogClose,
} from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import { CreateReviewModel } from '../models/create-models/review-create.mode';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { ReviewService } from '../services/review.service';
import { MatIconModule, MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';

const THUMBUP_ICON =
  `
  <svg xmlns="http://www.w3.org/2000/svg" width="24px" height="24px">
    <path d="M0 0h24v24H0z" fill="none"/>
    <path d="M1 21h4V9H1v12zm22-11c0-1.1-.9-2-2-2h-6.31l.95-4.57.03-.32c0-.41-.17-.79-.` +
  `44-1.06L14.17 1 7.59 7.59C7.22 7.95 7 8.45 7 9v10c0 1.1.9 2 2 2h9c.83 0 1.54-.5` +
  `1.84-1.22l3.02-7.05c.09-.23.14-.47.14-.73v-1.91l-.01-.01L23 10z"/>
  </svg>
`;



@Component({
  selector: 'app-app-details',
  standalone: true,
  imports: [CommonModule , MatButtonModule , MatFormFieldModule, MatInputModule, FormsModule, MatButtonModule , MatCheckboxModule , MatIconModule],
  templateUrl: './apps-details.component.html',
  styleUrl: './apps-details.component.css',
 

})
export class AppsDetailsComponent {
  current = 0;
  disableBuy = false;
  isInWishList = false;
  id : number | null = 0;
  app : AppDetailModel ={
    id : 0,
    title: '',
    titleCardPath: '',
    images: [],
    price: 0,
    createdAt: new Date(),
    description: '',
    releaseDate: new Date(),
    genres: [],
    reviews: []

  }
  sub: Subscription | undefined;

  review: CreateReviewModel = {
    id: 0,
    createdAt: new Date(),
    title: '',
    description:'',
    recommended: false,
    appId: this.app.id
  }

  

  constructor(private route: ActivatedRoute
    ,private appService: AppService ,
     private userSerivce: UserService 
     , private http: HttpClient 
    , private reloader: ReloadService 
    , public dialog: MatDialog 
    , private reviewService: ReviewService, 
    iconRegistry: MatIconRegistry,
     sanitizer: DomSanitizer) {
      iconRegistry.addSvgIconLiteral('thumbs-up', sanitizer.bypassSecurityTrustHtml(THUMBUP_ICON));
      iconRegistry.addSvgIcon('thumbs-down' ,sanitizer.bypassSecurityTrustResourceUrl("../assets/svg/thumb-down-svgrepo-com.svg"))
      }


  config = {
    autoplay: true,
    autoplaySpeed: 2000, // Set autoplay speed to 2 seconds (adjust as needed)
    slidesToShow: 1,
    slidesToScroll: 1
  };
  ngOnInit() {
    
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getAppDetails(this.id);
      
      this.userSerivce.GetById(this.userSerivce.getUserIdFromToken()).subscribe(user => {
        
      });
      this.app.releaseDate.toDateString();
      setInterval(() => {
        this.current = ++this.current % this.app.images.length;
      }, 2000);
    });
  }
  
  getAppDetails(id :number): void {
    this.appService.getAppById(id).subscribe(app => {this.app = app; this.app.releaseDate = new Date(app.releaseDate)
      
    })
    
    console.log(this.app);
  }
  
  Buy(id: number){
    console.log(id);
    const userId = this.userSerivce.getUserIdFromToken();
    this.userSerivce.GetById(userId).subscribe(user => {     
      console.log(user.appsLibrary);
      console.log(user.appsLibrary.some(a => a.id == id))
      if(!user.appsLibrary.some(a => a.id == id)){           
        this.userSerivce.Buy(id).subscribe(res => {this.reloader.reloadComponent.emit(); this.disableBuy = true});
      }
      else{
        console.log('its already in library')
      }
    }
    );

    
  }

  AddToWishList(id: number){

    this.userSerivce.AddToWishList(id).subscribe(res => this.reloader.reloadComponent.emit());
  }

  RemoveFromWishList(id: number){
    this.userSerivce.RemoveFromWishList(id).subscribe(res => this.reloader.reloadComponent.emit() );
  }

  CreateReview(id: number){
    this.review.appId = id;
    console.log(this.review);
    this.reviewService.createReview(this.review).subscribe(res => this.reloader.reloadComponent.emit());

  }
  
}





