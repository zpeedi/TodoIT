using System;
using Xunit;
using TodoIT.Model;



namespace TodoIT.Tests
{
    public class PersonTests
    {
        [Fact]
        public void IdCounter()
        {
            string firstname = "Magnus";
            string lastname = "Larsson";
            int befopreId = Person.IdCounter;
            Person testPerson = new Person(firstname, lastname);
            
            Assert.True(Person.IdCounter > befopreId);
        }

        [Fact]
        public void PersonId()
        {
            Person testPerson1 = new Person("Magnus", "Larsson");
            Person testPerson2 = new Person("Kent", "Larsson");
            Assert.NotEqual(testPerson1.PersonId, testPerson2.PersonId);
        }

        [Fact]
        public void Arguementexception()
        {
            Person testPerson1;

            Assert.Throws<ArgumentException>(() => testPerson1 = new Person("", "Larsson"));
            Assert.Throws<ArgumentException>(() => testPerson1 = new Person(null, "Larsson"));
        }

        [Fact]
        public void ConstructorAssignment()
        {
            string firstname = "Magnus";
            string lastname = "Larsson";           
            Person testPerson = new Person(firstname, lastname);

            Assert.Equal(testPerson.Firstname, firstname);
            Assert.Equal(testPerson.Lastname, lastname);
        }
    }
}
