using System;
using NServiceBus;

namespace TrashBin.Messages
{
    public class DeleteProject : ICommand
    {
        public Guid ProjectId { get; set; }
    }
}
