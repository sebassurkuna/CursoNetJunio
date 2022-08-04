import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DefaultErrorComponent } from './default-error.component';

describe('DefaultErrorComponent', () => {
  let component: DefaultErrorComponent;
  let fixture: ComponentFixture<DefaultErrorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DefaultErrorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DefaultErrorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
