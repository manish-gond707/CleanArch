using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.CleanArch.Domain.Core.Events;

namespace UMS.CleanArch.Domain.Core.Commands
{
    public abstract class Command: Message
    {
        private DateTime Timestamp { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
