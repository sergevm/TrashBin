using NServiceBus;

namespace TrashBin.Messages
{
    public class CreateProject : ICommand 
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
