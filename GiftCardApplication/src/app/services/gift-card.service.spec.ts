// import { TestBed } from '@angular/core/testing';
// import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

// import { GiftCardService } from './gift-card.service';
// import { GiftCard } from '../Models/GiftCard';

// describe('GiftCardService', () => {
//   let service: GiftCardService;
//   let httpMock: HttpTestingController;

//   beforeEach(() => {
//     TestBed.configureTestingModule({
//       imports: [HttpClientTestingModule],
//       providers: [GiftCardService]
//     });
//     service = TestBed.inject(GiftCardService);
//     httpMock = TestBed.inject(HttpTestingController);
//   });

//   afterEach(() => {
//     httpMock.verify();
//   });

//   it('shouldRetreive posts from the API via GET', () => {
//     const dummyPost: GiftCard[] = [
//       {
//         "giftCardId": 2,
//         "buyerName": "Sumit Pal",
//         "shippingAddress": "BL-12 BL Colony Bhubaneswar Odisha India PIN CODE:751007",
//         "city": "Bhubaneswar",
//         "amount": 1000,
//         "phone": "9876543211"
//       },
//       {
//         "giftCardId": 3,
//         "buyerName": "Madhab Mohanty",
//         "shippingAddress": "New Rail Colony Bhubaneswar Odisha India PIN CODE:751002",
//         "city": "Bhubaneswar",
//         "amount": 1000,
//         "phone": "9876543213"
//       }
//     ]

//     service.getGiftCardList().subscribe(deps => {
//       expect(deps.length).toBe(dummyPost.length);
//       expect(deps).toEqual(dummyPost)
//     });
//     const request = httpMock.expectOne(service.ApiUrl + '/giftcards');
//     expect(request.request.method).toBe('GET');
//     request.flush(dummyPost);
//   });
// });
