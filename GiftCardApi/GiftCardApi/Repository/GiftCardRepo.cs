using GiftCardApi.Models;
using GiftCardApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Repository
{
    public class GiftCardRepo : IGiftCardRepo
    {
        private readonly GiftCardContext _context;

        public GiftCardRepo(GiftCardContext context)
        {
            _context = context;
        }

        public void Create(GiftCardModel giftCard)
        {
            if (giftCard == null)
            {
                throw new ArgumentNullException();
            }
            _context.GiftCards.AddAsync(giftCard);
        }

        public async Task<IEnumerable<GiftCardModel>> GetAll()
        {
            return await _context.GiftCards.ToListAsync();
        }

        public async Task<bool> SaveChanges()
        {
            int a = await _context.SaveChangesAsync();
            return (a >= 0);
        }
    }
}
