using System;

namespace TrashBin.Domain.Tests.Integration.Initializers
{
    public class EnterpriseTestsDbInitializer : IntegrationTestDbInitializer
    {
        public Guid EnterpriseId { get; private set; }

        protected override void Seed(TrashBinContext context)
        {
            base.Seed(context);

            EnterpriseId = Guid.NewGuid();
                
            var enterprise = new Enterprise { Id = EnterpriseId, Name = "Software-Projects" };
            context.Companies.Add(enterprise);

            context.SaveChanges();
        }
    }
}