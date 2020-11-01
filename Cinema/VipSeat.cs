using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class VipSeat: Seat
    {
        decimal price;

        public decimal Price
        {
            get
            {
                return price;
            }

        }
        public VipSeat(decimal price)
        {
            this.price = price;
        }
    }
}
