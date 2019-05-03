import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TermoRowComponent } from './termo-row.component';

describe('TermoRowComponent', () => {
  let component: TermoRowComponent;
  let fixture: ComponentFixture<TermoRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TermoRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TermoRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
