using System.Data.Entity;

namespace TrashBin.Domain.Tests.Integration
{
    public abstract class EntityFrameworkTest<TDbInitializer> where TDbInitializer : DropCreateDatabaseAlways<TrashBinContext>, new()
    {
        protected TDbInitializer Initializer { get; private set; }

        protected EntityFrameworkTest()
        {
            Initializer = new TDbInitializer();
            Database.SetInitializer(Initializer);
            using (var context = new TrashBinContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}