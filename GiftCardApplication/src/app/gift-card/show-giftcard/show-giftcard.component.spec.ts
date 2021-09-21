import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowGiftcardComponent } from './show-giftcard.component';

describe('ShowGiftcardComponent', () => {
  let component: ShowGiftcardComponent;
  let fixture: ComponentFixture<ShowGiftcardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowGiftcardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowGiftcardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
