using System;
using System.Collections.Generic;
using System.Text;
using TodoIT.Model;

namespace TodoIT.Data
{
    public class People
    {
        private static Person[] personArray = new Person[0]; 
    
    
        public static int Size()
        {
            return personArray.Length;
        }

        public static Person[] FindAll()
        {
            return personArray;
        }

        public static Person FindById(int personId)
        {
            foreach(Person p in personArray)
            {
                if (p.PersonId == personId)
                {
                    return p;
                }
                        
            }
            return null;
        }

        public static Person NewPerson(string firstname, string lastname)
        {
            Person p = new Person(firstname, lastname);
            Array.Resize<Person>(ref personArray, personArray.Length + 1);
            personArray[personArray.Length - 1] = p;
            return p;
        }

        public static void Clear()
        {
            Array.Clear(personArray, 0, personArray.Length);
        }

    }
}
