using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Viewer
    {
        sbyte age;
        string firstName;
        string lastName;

        public sbyte Age { get { return age; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public Viewer(sbyte age, string firstName, string lastName)
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return string.Format($"Прізвище та ім'я глядача: {lastName} {firstName}, Вік: {age}");
        }
    }
}
