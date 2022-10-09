using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using voting_app.Data;
using voting_app.Entity;

namespace voting_app.Business
{
    public class UserControl
    {
        Db db = new Db();

        public bool Controller (string UserName, string Password)
        {
            Person person = db.Get(UserName);

            if (person.Password == Password)
            {
                return true;
            }
            else 
                return false;
        }

        public bool AddUser(string UserName, string Password)
        {
            int count = 0;
            List<Person> persons = db.GetPersons();

            foreach (Person person in persons)
            {
                if(person.Password == Password)
                {
                    count++;
                }
            }

            if(count == 0)
            {
                return false;
            }
            else
            {
                Person person = new Person
                {
                    Id = persons.Count + 1,
                    UserName = UserName,
                    Password = Password
                };

                persons.Add(person);
                return true; 
            }
        }


    }
}
