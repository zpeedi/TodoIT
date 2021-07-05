﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIT.Model
{
    public class Todo
    {
        private readonly int todoId;
        private String description;
        private bool done;
        private Person assignee;

        public Todo(int todoId, String description)
        {
            this.todoId = todoId;
            this.description = description;
        }

        public int TodoId {
            get { return todoId; }
        }

        public String Description
        {
            get { return description; }
        }

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }
    }
}
