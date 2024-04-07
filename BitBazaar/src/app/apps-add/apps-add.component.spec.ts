import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppsAddComponent } from './apps-add.component';

describe('AppAddComponent', () => {
  let component: AppsAddComponent;
  let fixture: ComponentFixture<AppsAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AppsAddComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AppsAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
