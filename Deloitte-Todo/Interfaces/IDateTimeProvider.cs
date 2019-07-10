using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deloitte.Todo.Interfaces
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentTime();
    }
}
