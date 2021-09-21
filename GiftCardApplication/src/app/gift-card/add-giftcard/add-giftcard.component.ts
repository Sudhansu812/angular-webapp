import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { GiftCardService } from 'src/app/services/gift-card.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-add-giftcard',
  templateUrl: './add-giftcard.component.html',
  styleUrls: ['./add-giftcard.component.css']
})
export class AddGiftcardComponent implements OnInit {

  constructor(
    public service: GiftCardService,
    private snackBar: MatSnackBar
  ) { }

  ngOnInit(): void {
    this.resetForm();
    this.dropdownRefresh();
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
    }
    this.service.formData = {
      giftCardId:0,
      buyerName: '',
      recipientName: '',
      shippingAddress: '',
      streetAddress: '',
      city: '',
      state: '',
      country: '',
      pinCode: '',
      email: '',
      gender: '',
      occasion: '',
      amount: 0,
      phone: ''
    }
  }

  public listItems: Array<string> = [];

  dropdownRefresh() {
    this.listItems = ['Birthday', 'Marriage'];
  }

  onSubmit(form: NgForm) {
    this.service.addGiftCard(form.value).subscribe(res => {
      this.resetForm(form);
      this.snackBar.open("Added Successfully", '', {
        duration: 4500,
        verticalPosition: 'top'
      }
      );
    });
  }

}
