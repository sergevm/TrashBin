using Microsoft.AspNet.SignalR;
using NServiceBus;
using TrashBin.Messages.Events;
using TrashBin.Mvc.Hubs;

namespace TrashBin.Mvc.EventHandlers
{
    public class ProjectCreatedHandler : IHandleMessages<ProjectCreatedEvent>
    {
        public void Handle(ProjectCreatedEvent message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<AsyncWorkNotificationHub>();
            context.Clients.All.notify(message.ProjectId);
        }
    }
}