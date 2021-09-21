using AutoMapper;
using GiftCardApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Models.Profiles
{
    public class GiftCardProfiles : Profile
    {
        public GiftCardProfiles()
        {
            CreateMap<GiftCardModel, GiftCardReadDto>();
            CreateMap<GiftCardCreateDto, GiftCardModel>();
        }
    }
}
