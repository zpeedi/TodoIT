using System;
using System.Collections.Generic;
using System.Text;
using TodoIT.Model;
using Xunit;

namespace TodoIT.Tests
{
    public class TodoTests
    {
        [Fact]
        public void ConstructorAssignemnts()
        {
            Todo todo = new Todo(5, "test");

            Assert.Equal(5, todo.TodoId);
            Assert.Equal("test", todo.Description);
        } 
    }
}
