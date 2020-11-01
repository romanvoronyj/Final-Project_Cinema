using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Film[] film = new Film[3];


            film[0] = new Film(1, "Хоробре серце", 12, "Бойовик, історичний", 150.0M, new DateTime(2020, 10, 23), new DateTime(2020, 11, 10));
            film[1] = new Film(2, "Врятувати рядового Раяна", 12, "Воєнний, історичний", 120.0M, new DateTime(2020, 10, 29), new DateTime(2020, 11, 8));
            film[2] = new Film(3, "Форсаж", 12, "Перегони, пригодницький", 200.0M, new DateTime(2020, 11, 1), new DateTime(2020, 11, 20));

            FilmScreening[] filmScreenings = new FilmScreening[6];
            filmScreenings[0] = new FilmScreening(1, film[0], new Hall(1, 500, 90), new DateTime(2020, 11, 2, 16, 45, 00));
            filmScreenings[1] = new FilmScreening(2, film[1], new Hall(3, 300, 50), new DateTime(2020, 11, 5, 18, 15, 00));
            filmScreenings[2] = new FilmScreening(3, film[2], new Hall(5, 250, 180), new DateTime(2020, 11, 4, 14, 30, 00));
            filmScreenings[3] = new FilmScreening(1, film[0], new Hall(2, 100, 110), new DateTime(2020, 11, 8, 20, 30, 00));
            filmScreenings[4] = new FilmScreening(2, film[1], new Hall(3, 300, 60), new DateTime(2020, 11, 7, 15, 15, 00));
            filmScreenings[5] = new FilmScreening(3, film[2], new Hall(2, 250, 200), new DateTime(2020, 11, 5, 19, 30, 00));

            Console.ReadKey();

        }
    }
}

