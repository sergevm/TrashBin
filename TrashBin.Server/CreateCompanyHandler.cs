using System;
using NServiceBus;
using TrashBin.Domain;
using TrashBin.Messages;

namespace TrashBin.Server
{
    public class CreateCompanyHandler : IHandleMessages<CreateCompany>
    {
        public void Handle(CreateCompany message)
        {
            using (var context = new TrashBinContext())
            {
                var company = new Enterprise {Name = message.Name, EnterpriseId = Guid.NewGuid()};
                context.Companies.Add(company);
                context.SaveChanges();
            }
        }
    }
}
