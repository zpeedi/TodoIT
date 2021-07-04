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
    }
}
