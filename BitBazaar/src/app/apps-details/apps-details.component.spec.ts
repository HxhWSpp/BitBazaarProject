import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppsDetailsComponent } from './apps-details.component';

describe('AppDetailsComponent', () => {
  let component: AppsDetailsComponent;
  let fixture: ComponentFixture<AppsDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AppsDetailsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AppsDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
