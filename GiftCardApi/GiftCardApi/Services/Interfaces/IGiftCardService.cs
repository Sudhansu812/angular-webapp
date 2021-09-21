using GiftCardApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Services.Interfaces
{
    public interface IGiftCardService
    {
        Task<IEnumerable<GiftCardReadDto>> GetAll();

        Task<GiftCardReadDto> Create(GiftCardCreateDto giftCardCreateDto);
    }
}
