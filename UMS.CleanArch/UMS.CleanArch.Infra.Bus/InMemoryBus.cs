using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.CleanArch.Domain.Core.Bus;
using UMS.CleanArch.Domain.Core.Commands;

namespace UMS.CleanArch.Infra.Bus
{
    public class InMemoryBus: ImediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendCommand<T> (T command) where T : Command
        {
            await _mediator.Send(command);
        }
    }
}
