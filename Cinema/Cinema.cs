using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        string name;
        decimal money;
        Film[] films;
        Hall[] halls;
        Ticket[] tickets;



        //список ПроданіКвитки(не клас)

        /*Метод Film[] GetFilms() повинен показуватиІнформацію про усі фільми, які ідуть у кінотеатрі зараз. Мається на увазі у яких endDate>= nowDate.*/
        public Film[] GetFilms()
        {
            List<Film> availableFilms = new List<Film>();
            DateTime nowDate = DateTime.Now;
            foreach (var film in films)
            {
                if (film.endDate >= nowDate)
                {
                    availableFilms.Add(film);
                }
            }
            return availableFilms.ToArray();

        }
         /*Метод FilmScreening[]GetFilmScreenings(int filmId)показувати Інформацію про конкретний фільм, а саме усі покази цього фільму. Метод повинен фільтрувати 
         * масив films, а саме по полю filmId, яке є у Film(ПоказФільму, Фільм, Зал)і повертати FilmScreenings відфільтрований по даті яка актуальна.
         * Якщо такого фільму не буде знайдено необхідно викинути виняток NotExistException із відповідним повідомленням.
         public FilmScreening[] GetFilmScreenings(int filmId)
        */
        //public FilmScreening[] GetFilmScreenings(int filmId)
        //{
        //    filmId
        //}
    }
}


//-класи(без методів), поля+властивості, конструктори);
//-реальні фільми, передати всі параметри в конструктори;
//-реалізувати усі методи ToString
//-по одному методу поступово (викликати в Program) 