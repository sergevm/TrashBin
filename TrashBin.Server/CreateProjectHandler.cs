using System;
using NServiceBus;
using TrashBin.Domain;
using TrashBin.Messages;

namespace TrashBin.Server
{
    public class CreateProjectHandler : IHandleMessages<CreateProject>
    {
        public void Handle(CreateProject message)
        {
            using (var context = new TrashBinContext())
            {
                var project = new Project {Id = Guid.NewGuid(), Name = message.Name, Description = message.Description};
                context.Projects.Add(project);
                context.SaveChanges();
            }
        }
    }
}