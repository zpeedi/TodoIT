using System;
using System.Collections.Generic;
using System.Text;
using TodoIT.Data;
using TodoIT.Model;
using Xunit;


namespace TodoIT.Tests
{

    /* Jag väljer att inte testa mina "enradsanrop" eftersom 
     * det bara skulle testa ett färdigt .NET anrop.
     */
    public class PeopleTests
    {
        [Fact]
        public void NewPersonTest() {

            string firstname = "Magnus";
            string lastname = "Larsson";
            People.NewPerson(firstname, lastname);
            Person p = People.FindAll()[People.Size()-1];

            Assert.Equal(p.Firstname, firstname);
            Assert.Equal(p.Lastname, lastname);

        }
    
        [Fact]
        public void FindByIdTest()
        {

            string firstname = "Petter";
            string lastname = "Karlsson";
            int personId = 1;

            People.NewPerson(firstname, lastname);
            Person p = People.FindById(personId);

            Assert.Equal(personId, p.PersonId);


        }
        [Fact]
        public void RemoveTest()
        {
            int idToRemove;
            int sizeBefore;

            Person p1 = People.NewPerson("Kalle", "Fredriksson");
            Person p2 = People.NewPerson("Olle", "Karlsson");
            Person p3 = People.NewPerson("Bengt", "Larsson");
            Person p4 = People.NewPerson("Sven", "Persson");
         
            idToRemove = p2.PersonId;
            sizeBefore = People.Size();

            People.Remove(idToRemove);

            Assert.Equal(sizeBefore, People.Size() + 1);
            Assert.Null(People.FindById(idToRemove));

        }
    }

    
}
