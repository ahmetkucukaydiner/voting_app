using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using voting_app.Entity;

namespace voting_app.Data
{
    public class Db
    {
        private static List<Person> _person;

        static Db()
        {
            _person = new List<Person>()
            {
                new Person { Id = 1, UserName = "Murat", Password = "1234" },
                new Person { Id = 2, UserName = "Meltem", Password = "1234" },
                new Person { Id = 3, UserName = "Ayfer", Password = "1234" },
                new Person { Id = 4, UserName = "Gülşah", Password = "1234" },
            };
        }

        public List<Person> GetPersons()
        {
             return _person;
        }

        public Person Get(string userName)
        {
            return _person.Find(x => x.UserName == userName);
        }
    }
}
