using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Ticket
    {
        long number;
        FilmScreening filmScreening;
        Seat seat;
        Viewer viewer;
        decimal price;

        public long Number { get { return number; } }

        public Ticket(long number, FilmScreening filmScreening, Seat seat, Viewer viewer, decimal price)
        {
            this.number = number;
            this.filmScreening = filmScreening;
            this.seat = seat;
            this.viewer = viewer;
            this.price = price;
        }
        public override string ToString()
        {
            return string.Format($"Квиток №:{number},місце №:{seat}, ціна:{price}");
        }
    }

}
