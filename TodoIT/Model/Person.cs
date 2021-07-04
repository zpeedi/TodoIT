using System;
using System.Collections.Generic;
using System.Text;
using TodoIT.Data;
namespace TodoIT.Model
{
    public class Person
    {
        private static int idCounter = 0;
        private readonly int personId;
        private string firstname;
        private string lastname;

        public Person(string firstname, string lastname)
        {
            //jag tolkar 8e som att jag skall göra så här.
            personId = PersonSequencer.nextPersonId(); 
            Firstname = firstname;
            Lastname = lastname;
        }

        public int PersonId
        {
            get { return personId; }
        }
        public static int IdCounter
        {
            get { return idCounter; }
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                firstname = value;
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                lastname = value;
            }
        }

       

    }
}
