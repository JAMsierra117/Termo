import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TermoGridComponent } from './termo-grid.component';

describe('TermoGridComponent', () => {
  let component: TermoGridComponent;
  let fixture: ComponentFixture<TermoGridComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TermoGridComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TermoGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
