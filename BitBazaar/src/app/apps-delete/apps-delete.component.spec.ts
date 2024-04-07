import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppsDeleteComponent } from './apps-delete.component';

describe('AppsDeleteComponent', () => {
  let component: AppsDeleteComponent;
  let fixture: ComponentFixture<AppsDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AppsDeleteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AppsDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
