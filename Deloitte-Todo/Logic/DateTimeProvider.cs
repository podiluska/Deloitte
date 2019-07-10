using Deloitte.Todo.Interfaces;
using System;

namespace Deloitte.Todo.Logic
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
