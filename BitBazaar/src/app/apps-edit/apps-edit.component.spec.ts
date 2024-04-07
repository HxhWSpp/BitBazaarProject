import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppsEditComponent } from './apps-edit.component';

describe('AppsEditComponent', () => {
  let component: AppsEditComponent;
  let fixture: ComponentFixture<AppsEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AppsEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AppsEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
