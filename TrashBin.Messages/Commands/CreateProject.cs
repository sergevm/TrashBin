using NServiceBus;

namespace TrashBin.Messages.Commands
{
    public class CreateProject : ICommand 
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
