using System;
using System.Data.Entity;

namespace TrashBin.Domain
{
    public class TrashBinDatabaseInitializer : DropCreateDatabaseIfModelChanges<TrashBinContext> 
    {
        protected override void Seed(TrashBinContext context)
        {
            var company = new Enterprise {Id = Guid.NewGuid(), Name = "Sofware-Projects"};
            context.Companies.Add(company);

            context.SaveChanges();
        }
    }
}
