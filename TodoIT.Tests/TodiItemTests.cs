using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIT.Model;
using TodoIT.Data;


namespace TodoIT.Tests
{
    public class TodiItemTests
    {
        [Fact]
        public void NewTodoTest()
        {

            string description = "Kul grej";
            Todo t = new Todo(TodoSequencer.nextTodoSequencerId(), description);
            Person p = People.FindAll()[People.Size() - 1];

            Assert.Equal(t.Description, description);          
        }

        [Fact]
        public void FindByIdTest()
        {

            string description = "Kul grej";
            int todoId = 1;

            TodoItems.NewTodo(description);
            
            Todo t = TodoItems.FindById(todoId);

            Assert.Equal(todoId, t.TodoId);


        }
    }
}
