using System.Linq;
using NServiceBus;
using TrashBin.Domain;
using TrashBin.Messages;
using TrashBin.Messages.Commands;

namespace TrashBin.Server
{
    public class DeleteProjectHandler : IHandleMessages<DeleteProject>
    {
        public void Handle(DeleteProject message)
        {
            using (var context = new TrashBinContext())
            {
                var project = context.Projects.First(p => p.Id == message.ProjectId);
                context.Projects.Remove(project);

                context.SaveChanges();
            }
        }
    }
}
