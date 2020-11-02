using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Hall: IShortInfo
    {
        int number;
        int seatsNumber;
        List<Seat> seats;
        decimal price;

        public int Number { get { return number; } }
        public int SeatsNumber { get { return seatsNumber; } }
        public List<Seat> _seats{ get { return seats; } }
        public decimal Price { get { return price; } }

        public Hall(int number, int seatsNumber, List<Seat> seats, decimal price)
        {
            this.number = number;
            this.seatsNumber = seatsNumber;
            this.seats = _seats;
            this.price = price;
        }
        public override string ToString()
        {
            return string.Format($"Кінозал 3D на {_seats} осіб");
        }
        public string ToShortString()
        {
            return string.Format($"Кінозал: 3D ");
        }
    }
}
