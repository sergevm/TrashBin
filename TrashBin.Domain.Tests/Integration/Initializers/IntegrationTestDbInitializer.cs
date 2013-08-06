using System.Data.Entity;

namespace TrashBin.Domain.Tests.Integration.Initializers
{
    public class IntegrationTestDbInitializer : DropCreateDatabaseAlways<TrashBinContext>
    {
    }
}
