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

        [Fact]
        public void FindByDoneStatusTest()
        {
            TodoItems.Clear();
            Todo t1 = TodoItems.NewTodo("Gul");
            t1.Done = true;
            Todo t2 = TodoItems.NewTodo("Grön");
            Todo t3 = TodoItems.NewTodo("Blå");
            Todo t4 = TodoItems.NewTodo("Röd");
            t4.Done = true;

            Todo[] todoArray = TodoItems.FindByDoneStatus(true);
            Assert.Equal(t1.TodoId, todoArray[0].TodoId);
            Assert.Equal(t4.TodoId, todoArray[1].TodoId);

            TodoItems.Clear();
        }
        [Fact]
        public void FindByAssigneeIdTest()
        {
            
            TodoItems.Clear();
            Person p = new Person("Magnus", "Larsson");
            Todo t1 = TodoItems.NewTodo("Gul");
            t1.Assignee = p;
            Todo t2 = TodoItems.NewTodo("Grön");
            Todo t3 = TodoItems.NewTodo("Blå");
            Todo t4 = TodoItems.NewTodo("Röd");
            t4.Assignee = p;


            Todo[] todoArray = TodoItems.FindByAssignee(p.PersonId);
            Assert.Equal(t1.TodoId, todoArray[0].TodoId);
            Assert.Equal(t4.TodoId, todoArray[1].TodoId);

            TodoItems.Clear();
        }

          [Fact]
        public void FindByAssigneePersonTest()
        {

            TodoItems.Clear();
            Person p = new Person("Magnus", "Larsson");
            Todo t1 = TodoItems.NewTodo("Gul");
            t1.Assignee = p;
            Todo t2 = TodoItems.NewTodo("Grön");
            Todo t3 = TodoItems.NewTodo("Blå");
            Todo t4 = TodoItems.NewTodo("Röd");
            t4.Assignee = p;


            Todo[] todoArray = TodoItems.FindByAssignee(p);
            Assert.Equal(t1.TodoId, todoArray[0].TodoId);
            Assert.Equal(t4.TodoId, todoArray[1].TodoId);

            TodoItems.Clear();
        }

        [Fact]
        public void FindUnasignedTodoItemsTest()
        {
           
            TodoItems.Clear();
            Person p = new Person("Magnus", "Larsson");
            Todo t1 = TodoItems.NewTodo("Gul");
            t1.Assignee = p;
            Todo t2 = TodoItems.NewTodo("Grön");
            Todo t3 = TodoItems.NewTodo("Blå");
            Todo t4 = TodoItems.NewTodo("Röd");
            t4.Assignee = p;


            Todo[] todoArray = TodoItems.FindUnassignedTodoItems();
            Assert.Equal(t2.TodoId, todoArray[0].TodoId);
            Assert.Equal(t3.TodoId, todoArray[1].TodoId);

            TodoItems.Clear();
        }

        [Fact]
        public void RemoveTest()
        {
            int idToRemove;
            int sizeBefore;

            Todo t1 = TodoItems.NewTodo("Gul");
            Todo t2 = TodoItems.NewTodo("Grön");
            Todo t3 = TodoItems.NewTodo("Blå");
            Todo t4 = TodoItems.NewTodo("Röd");
            idToRemove = t2.TodoId;
            sizeBefore = TodoItems.Size();

            TodoItems.Remove(idToRemove);

            Assert.Equal(sizeBefore, TodoItems.Size()+1);
            Assert.Null(TodoItems.FindById(idToRemove));

        }
    }
}
