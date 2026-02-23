using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.CleanArch.Domain.Core.Commands;

namespace UMS.CleanArch.Domain.Core.Bus
{
    public interface ImediatorHandler
    {
        Task SendCommand<T>(T Command) where T : Command;
    }
}
