using System;
using System.Collections.Generic;
using System.Text;
using TodoIT.Model;

namespace TodoIT.Data
{
    public class TodoItems 
    {
        private static Todo[] todoArray = new Todo[0];


        public static int Size()
        {
            return todoArray.Length;
        }

        public static Todo[] FindAll()
        {
            return todoArray;
        }

        public static Todo FindById(int todoId)
        {
            foreach (Todo t in todoArray)
            {
                if (t.TodoId == todoId)
                {
                    return t;
                }

            }
            return null;
        }

        public static Todo NewTodo(string description)
        {
            Todo t = new Todo(TodoSequencer.TodoSequencerId, description);
            Array.Resize<Todo>(ref todoArray, todoArray.Length + 1);
            todoArray[todoArray.Length - 1] = t;
            return t;
        }

        public static void Clear()
        {
            Array.Clear(todoArray, 0, todoArray.Length);
        }

        public static Todo[] FindByDoneStatus(bool doneStatus)
        {
            int dones = 0;
            foreach(Todo t in todoArray)
            {
                if (t.Done == doneStatus)
                {
                    dones++;
                }
            }

            Todo[] doneArray = new Todo[dones];

            foreach (Todo t in todoArray)
            {
                if (t.Done == doneStatus)
                {                    
                    doneArray[doneArray.Length - dones--] = t;
                }
            }
            return doneArray;
        }

        public static Todo[] FindByAssignee(int personId)
        {
            int todos = 0;
            foreach (Todo t in todoArray)
            {
                if (t.Assignee.PersonId == personId)
                {
                    todos++;
                }
            }

            Todo[] tmpArray = new Todo[todos];

            foreach (Todo t in todoArray)
            {
                if (t.Assignee.PersonId == personId)
                {
                    tmpArray[tmpArray.Length - todos--] = t;
                }
            }
            return tmpArray;
        }

        public static Todo[] FindByAssignee(Person p)
        {
            return FindByAssignee(p.PersonId);
        }

        public static Todo[] FindUnassignedTodoItems()
        {
            int unassigned = 0;
            foreach (Todo t in todoArray)
            {
                if (t.Assignee == null)
                {
                    unassigned++;
                }
            }

            Todo[] tmpArray = new Todo[unassigned];

            foreach (Todo t in todoArray)
            {
                if (t.Assignee == null)
                {
                    tmpArray[tmpArray.Length - unassigned--] = t;
                }
            }
            return tmpArray;
        }

    }
}
