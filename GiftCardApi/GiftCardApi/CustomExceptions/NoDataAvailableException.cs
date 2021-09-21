using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.CustomExceptions
{
    public class NoDataAvailableException : Exception
    {
        public NoDataAvailableException(string msg) : base(msg) { }
    }
}
