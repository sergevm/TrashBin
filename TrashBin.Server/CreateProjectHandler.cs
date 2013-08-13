using System;
using System.Threading;
using NServiceBus;
using TrashBin.Domain;
using TrashBin.Messages.Commands;
using TrashBin.Messages.Events;

namespace TrashBin.Server
{
    public class CreateProjectHandler : IHandleMessages<CreateProject>
    {
        private readonly IBus bus;

        public CreateProjectHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(CreateProject message)
        {
            using (var context = new TrashBinContext())
            {
                var project = new Project {Id = Guid.NewGuid(), Name = message.Name, Description = message.Description};
                context.Projects.Add(project);
                context.SaveChanges();

                // DEMO purposes ...
                Thread.Sleep(2000);

                bus.Publish(new ProjectCreatedEvent { ProjectId = project.Id });
            }
        }
    }
}