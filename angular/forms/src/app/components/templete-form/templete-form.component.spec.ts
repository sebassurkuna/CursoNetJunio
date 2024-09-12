import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TempleteFormComponent } from './templete-form.component';

describe('TempleteFormComponent', () => {
  let component: TempleteFormComponent;
  let fixture: ComponentFixture<TempleteFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TempleteFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TempleteFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
