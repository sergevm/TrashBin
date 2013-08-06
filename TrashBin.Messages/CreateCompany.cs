using NServiceBus;

namespace TrashBin.Messages
{
    public class CreateCompany : ICommand 
    {
        public string Name { get; set; }
    }
}
