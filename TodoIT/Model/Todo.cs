using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIT.Model
{
    public class Todo
    {
        private readonly int todoIt;
        private String description;
        private bool done;
        private Person assignee;

        public Todo(int todoIt, String description)
        {
            this.todoIt = todoIt;
            this.description = description;
        }

        public int TodoIT {
            get { return todoIt; }
        }

        public String Description
        {
            get { return description; }
        }
    }
}
