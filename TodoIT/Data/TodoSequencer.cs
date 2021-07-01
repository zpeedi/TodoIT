using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIT.Data
{
    public class TodoSequencer
    {
        private static int todoSequencerId;

        public static int TodoSequencerId
        {
            get { return todoSequencerId; }
        }
        public static int nextTodoSequencerId()
        {
            return ++todoSequencerId;
        }

        public static void reset()
        {
            todoSequencerId = 0;
        }
    }
}
