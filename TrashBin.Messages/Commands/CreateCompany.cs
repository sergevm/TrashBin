using NServiceBus;

namespace TrashBin.Messages.Commands
{
    public class CreateCompany : ICommand 
    {
        public string Name { get; set; }
    }
}
