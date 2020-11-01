using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class SeatPlace : Seat
    {
        bool busy;

        public bool PlaceAvailability { get { return busy; } }
    }
}
