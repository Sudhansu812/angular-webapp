import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddGiftcardComponent } from './add-giftcard.component';

describe('AddGiftcardComponent', () => {
  let component: AddGiftcardComponent;
  let fixture: ComponentFixture<AddGiftcardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddGiftcardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddGiftcardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
