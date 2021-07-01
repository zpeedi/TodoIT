using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIT.Data;

namespace TodoIT.Tests
{
    public class TodoSequencerTest
    {
        [Fact]
        public void resetTest()
        {
            TodoSequencer.nextTodoSequencerId();
            TodoSequencer.nextTodoSequencerId();
            TodoSequencer.reset();

            Assert.Equal(0, TodoSequencer.TodoSequencerId);
        }

        [Fact]
        public void nextPersoIdTest()
        {
            int before = TodoSequencer.TodoSequencerId;
            TodoSequencer.nextTodoSequencerId();

            Assert.True(before < TodoSequencer.TodoSequencerId);
        }
    }
}
