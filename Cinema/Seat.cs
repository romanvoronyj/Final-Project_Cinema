using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    abstract class Seat
    {
        int number;

        public int Number
        {
            get
            {
                return number;
            }
        }

        public Seat(int number)
        {
            this.number = number;
        }

    }
}
