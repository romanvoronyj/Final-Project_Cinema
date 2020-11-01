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
        Seat[] seats;
        decimal price;

        public int Number { get { return number; } }
        public int SeatsNumber { get { return seatsNumber; } }
        public Seat this[int index] { get { return seats[index]; } }
        public decimal Price { get { return price; } }

        public Hall(int number, int seatsNumber, decimal price)
        {
            this.number = number;
            this.seatsNumber = seatsNumber;
            this.price = price;
        }
        public override string ToString()
        {
            return string.Format("$Кінозал 3D на 500 осіб");
        }
        public string ToShortString()
        {
            return ($"Кінозал: 3D ");
        }
    }
}
