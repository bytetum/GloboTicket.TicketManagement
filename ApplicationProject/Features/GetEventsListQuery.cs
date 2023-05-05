using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProject.Features
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
        public Guid Id { get; set; }
    }
}
