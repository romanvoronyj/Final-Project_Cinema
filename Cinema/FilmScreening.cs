using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class FilmScreening: IShortInfo
    {
        int filmScreeningId;
        Film film;
        Hall hall;
        List<SeatPlace> seatPlaces;
        DateTime dateTime;
        public int FilmScreeningId { get { return filmScreeningId; } }
        public List<SeatPlace> SeatPlaces { get { return seatPlaces; } set { seatPlaces = value; } }

        public FilmScreening(int filmScreeningId, Film film, Hall hall,  DateTime dateTime)
        {
            this.filmScreeningId = filmScreeningId;
            this.film = film;
            this.hall = hall;
            this.dateTime = dateTime;
        }

        public override string ToString()
        {
            return ($"Сеанс: {filmScreeningId}, Назва фільму: {film}, Зал: {hall.Number}, Кількість місць: {seatPlaces}, Дата та час: {dateTime}");
        }
        public string ToShortString()
        {
            return ($"Назва фільму: {film}, Сеанс: {filmScreeningId}");
        }
    }
}
