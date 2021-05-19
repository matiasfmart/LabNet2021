import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormAbmComponent } from './form-abm.component';

describe('FormAbmComponent', () => {
  let component: FormAbmComponent;
  let fixture: ComponentFixture<FormAbmComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormAbmComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormAbmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
