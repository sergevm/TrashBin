using System;

namespace TrashBin.Domain
{
    public class Enterprise : Entity 
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public Guid? AddressId { get; set; }
    }
}
