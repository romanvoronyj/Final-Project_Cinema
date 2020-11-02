using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Film
    {
        public int filmId;
        string name;
        int minAge;
        string description;
        decimal price;
        DateTime startDate;
        public DateTime endDate;
        List<FilmScreening> filmScreenings;


        public int FilmId
        {
            get
            {
                return filmId;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int MinAge
        {
            get
            {
                return minAge;
            }
            //set
            //{
            //    if(value < 18)
            //    {
            //        Console.WriteLine("Показ фільму неповнолітнім ЗАБОРОНЕНО");
            //    }
            //    minAge = value;
            //}
        }
        public string Description
        {
            get
            {
                return description;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
        }
        public List<FilmScreening> FilmScreenings
        {
            get
            {
                return filmScreenings;
            }
            set
            {
                filmScreenings = value;
            }
        }
        public Film (int filmId, string name, int minAge, string description, decimal price, DateTime startDate, DateTime endDate)
        {
            this.filmId = filmId;
            this.name = name;
            this.minAge = minAge;
            this.description = description;
            this.price = price;
            this.startDate = startDate;
            this.endDate = endDate;
        }


        public override string ToString()
        {
            return "Фільм, що розповідає про боротьбу Королівства Шотландія за незалежність проти англійського панування. Головний герой фільму — Вільям Воллес, ватажок шотландців, у виконанні Мела Гібсона.";
        }
        public string ToShortString()
        {
            string review = "Прем'єра: 1995 рік.\nТривалість: 177 хв.\nКасові збори:$210 мільйонів.";
            return(review);
        }
    }
}
