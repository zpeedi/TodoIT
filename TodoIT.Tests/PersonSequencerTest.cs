using System;
using System.Collections.Generic;
using System.Text;
using TodoIT.Data;
using Xunit;


namespace TodoIT.Tests
{
    public class PersonSequencerTest
    {
        [Fact]
        public void resetTest()
        {
            PersonSequencer.nextPersonId();
            PersonSequencer.nextPersonId();
            PersonSequencer.reset();

            Assert.Equal(0, PersonSequencer.PersonId);
        }

        [Fact]
        public void nextPersoIdTest()
        {
            int before = PersonSequencer.PersonId;
            PersonSequencer.nextPersonId();

            Assert.True(before < PersonSequencer.PersonId);
        }
    }
}
