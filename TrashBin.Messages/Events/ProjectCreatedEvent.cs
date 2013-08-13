using System;
using NServiceBus;

namespace TrashBin.Messages.Events
{
    public class ProjectCreatedEvent : IEvent 
    {
        public Guid ProjectId { get; set; }
    }
}
