using GiftCardApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Repository
{
    public class GiftCardContext : DbContext
    {
        public GiftCardContext(DbContextOptions<GiftCardContext> options) : base(options) { }

        public DbSet<GiftCardModel> GiftCards { get; set; }
    }
}
