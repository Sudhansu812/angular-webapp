using GiftCardApi.Controllers;
using GiftCardApi.Models;
using GiftCardApi.Models.Dtos;
using GiftCardApi.Repository.Interfaces;
using GiftCardApi.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var mock = new Mock<IGiftCardService>();

            List<GiftCardReadDto> giftCards = new List<GiftCardReadDto>();
            
            GiftCardReadDto giftCardReadDto = new GiftCardReadDto() {
                GiftCardId = 2,
                BuyerName = "Sumit Pal",
                ShippingAddress = "BL-12 BL Colony Bhubaneswar Odisha India PIN CODE:751007",
                City = "Bhubaneswar",
                Amount = 1000,
                Phone = "9876543211"
            };

            giftCards.Add(giftCardReadDto);

            mock.Setup(p => p.GetAll()).ReturnsAsync(giftCards);

            GiftCardsController giftCard = new GiftCardsController(mock.Object);

            List<GiftCardReadDto> output = (await giftCard.GetAll()).ToList();

            Console.WriteLine(output[0].BuyerName);
            Console.WriteLine(giftCards[0].BuyerName);

            Assert.IsTrue(checkList(output, giftCards));
        }

        public bool checkList(List<GiftCardReadDto> list1, List<GiftCardReadDto> list2)
        {
            if(list1.Count != list2.Count)
            {
                return false;
            }
            for(int i=0;i<list1.Count;i++)
            {
                if (list1[i].GiftCardId == list2[i].GiftCardId && list1[i].BuyerName == list2[i].BuyerName && list1[i].ShippingAddress == list2[i].ShippingAddress &&
                    list1[i].City == list2[i].City && list1[i].Amount == list2[i].Amount && list1[i].Phone == list2[i].Phone)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
