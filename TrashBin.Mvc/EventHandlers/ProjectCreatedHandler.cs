using NServiceBus;
using TrashBin.Messages.Events;

namespace TrashBin.Mvc.EventHandlers
{
    public class ProjectCreatedHandler : IHandleMessages<ProjectCreatedEvent>
    {
        public void Handle(ProjectCreatedEvent message)
        {
        }
    }
}