using System;
using System.Data.Entity;

namespace TrashBin.Domain
{
    public class TrashBinDatabaseInitializer : DropCreateDatabaseAlways<TrashBinContext> 
    {
        protected override void Seed(TrashBinContext context)
        {
            var company = new Enterprise {Id = Guid.NewGuid(), Name = "Sofware-Projects"};
            context.Companies.Add(company);

            var partena = new Project {Id = Guid.NewGuid(), Name = "IAM Partena"};
            context.Projects.Add(partena);

            var fluxys = new Project {Id = Guid.NewGuid(), Name = "Fluxys"};
            context.Projects.Add(fluxys);

            context.SaveChanges();
        }
    }
}
