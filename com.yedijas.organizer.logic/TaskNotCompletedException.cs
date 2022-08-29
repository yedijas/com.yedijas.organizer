using System;

namespace com.yedijas.organizer.logic
{
    /// <summary>
    /// This is to ensure that I close the task before deleting it.
    /// </summary>
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
