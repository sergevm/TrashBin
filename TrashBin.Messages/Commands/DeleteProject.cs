using System;
using NServiceBus;

namespace TrashBin.Messages.Commands
{
    public class DeleteProject : ICommand
    {
        public Guid ProjectId { get; set; }
    }
}
