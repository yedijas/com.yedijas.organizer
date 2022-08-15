using System;

namespace com.yedijas.organizer.logic
{
    public class TaskNotCompletedException : Exception
    {
        public TaskNotCompletedException()
        {
        }

        public TaskNotCompletedException(string message)
            : base(message)
        {
        }

        public TaskNotCompletedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
