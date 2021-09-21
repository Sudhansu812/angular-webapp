import { Component, OnInit } from '@angular/core';

import { GiftCard } from 'src/app/Models/GiftCard';

import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { ViewChild } from '@angular/core';
import { GiftCardService } from 'src/app/services/gift-card.service'; 
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-show-giftcard',
  templateUrl: './show-giftcard.component.html',
  styleUrls: ['./show-giftcard.component.css']
})
export class ShowGiftcardComponent implements OnInit {

  constructor(
    private service: GiftCardService,
    private dialog: MatDialog,
    private snackBar: MatSnackBar
  ) { }

  listData: MatTableDataSource<any> = new MatTableDataSource<any>();
  displayedColumns: string[] = [
    'giftCardId', 
    'buyerName', 
    'shippingAddress', 
    'city', 
    'amount', 
    'phone'
  ];

  @ViewChild(MatSort) sort: MatSort;

  ngOnInit(): void {
    this.listData.sort = this.sort;
    this.refreshGiftCardList();
  }

  refreshGiftCardList() {
    this.service.getGiftCardList().subscribe(data => {
      this.listData = new MatTableDataSource(data);
      this.listData.sort = this.sort;
    });
  }

  applyFilter(filtervalue: string) {
    this.listData.filter = filtervalue.trim().toLowerCase();
  }

}
