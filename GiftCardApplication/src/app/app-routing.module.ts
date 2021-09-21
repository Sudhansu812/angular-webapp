import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddGiftcardComponent } from './gift-card/add-giftcard/add-giftcard.component';
import { GiftCardComponent } from './gift-card/gift-card.component';
import { ShowGiftcardComponent } from './gift-card/show-giftcard/show-giftcard.component';

const routes: Routes = [
  { path: 'placeorder', component: AddGiftcardComponent },
  { path: 'vieworder', component: ShowGiftcardComponent },
  { path: 'home', component: GiftCardComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
