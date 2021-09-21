using AutoMapper;
using GiftCardApi.CustomExceptions;
using GiftCardApi.Models;
using GiftCardApi.Models.Dtos;
using GiftCardApi.Repository.Interfaces;
using GiftCardApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Services
{
    public class GiftCardService : IGiftCardService
    {
        private readonly IGiftCardRepo _repository;
        private readonly IMapper _mapper;

        public GiftCardService(IGiftCardRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GiftCardReadDto> Create(GiftCardCreateDto giftCardCreateDto)
        {
            GiftCardModel giftCard = _mapper.Map<GiftCardModel>(giftCardCreateDto);

            giftCard.ShippingAddress = giftCard.StreetAddress + " " + giftCard.City + " " + giftCard.State +
                    " " + giftCard.Country + " PIN CODE:" + giftCard.PinCode;
            try
            {
                _repository.Create(giftCard);
            }
            catch
            {
                return null;
            }
            if (await _repository.SaveChanges() == false)
            {
                return null;
            }
            return _mapper.Map<GiftCardReadDto>(giftCard);
        }

        public async Task<IEnumerable<GiftCardReadDto>> GetAll()
        {
            List<GiftCardModel> giftCards = (await _repository.GetAll()).ToList();

            if (giftCards.Count == 0)
            {
                throw new NoDataAvailableException("NO data available");
            }
            //for (int i = 0; i < giftCards.Count; i++) {
            //    giftCards[i].ShippingAddress = giftCards[i].StreetAddress + " " + giftCards[i].City + " " + giftCards[i].State +
            //        " " + giftCards[i].Country + " PIN CODE:" + giftCards[i].PinCode;
            //}
            return _mapper.Map<IEnumerable<GiftCardReadDto>>(giftCards);
        }
    }
}
