import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { GiftCard } from '../Models/GiftCard';
import { Observable } from 'rxjs'; 

import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GiftCardService {

  constructor(private http: HttpClient) { }

  formData: GiftCard;

  readonly ApiUrl = "https://localhost:44376/api";

  getGiftCardList(): Observable<GiftCard[]> {
    return this.http.get<GiftCard[]>(this.ApiUrl + "/giftcards");
  }

  addGiftCard(giftCard: GiftCard) {
    return this.http.post(this.ApiUrl + '/giftcards', giftCard);
  }


  // The following methods are for refreshing the grid even after closing the
  // dialog box.
  private _listeners = new Subject<any>();
  listen(): Observable<any> {
    return this._listeners.asObservable();
  }
  filter(filterBy: string) {
    this._listeners.next(filterBy);
  }

}
