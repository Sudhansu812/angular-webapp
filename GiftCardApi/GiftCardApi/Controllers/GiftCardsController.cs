using GiftCardApi.Models.Dtos;
using GiftCardApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Controllers
{
    [Route("api/giftcards")]
    [ApiController]
    public class GiftCardsController : ControllerBase
    {
        private readonly IGiftCardService _services;
        public GiftCardsController(IGiftCardService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IEnumerable<GiftCardReadDto>> GetAll()
        {
            return await _services.GetAll() as List<GiftCardReadDto>;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Create(GiftCardCreateDto createDto)
        {
            GiftCardReadDto giftCard = await _services.Create(createDto);
            if (giftCard == null)
            {
                return BadRequest();
            }
            return "Gift Card Added Successfully";
        }
    }
}
