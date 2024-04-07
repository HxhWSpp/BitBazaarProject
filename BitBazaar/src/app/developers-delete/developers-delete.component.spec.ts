import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DevelopersDeleteComponent } from './developers-delete.component';

describe('DevelopersDeleteComponent', () => {
  let component: DevelopersDeleteComponent;
  let fixture: ComponentFixture<DevelopersDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DevelopersDeleteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DevelopersDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
