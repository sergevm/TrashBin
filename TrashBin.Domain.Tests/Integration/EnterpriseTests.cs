using System.Linq;
using TrashBin.Domain.Tests.Integration.Initializers;
using Xunit;

namespace TrashBin.Domain.Tests.Integration
{
    public class EnterpriseTests : EntityFrameworkTest<EnterpriseTestsDbInitializer>
    {
        [Fact]
        public void ThenTheEnterpriseIsPersisted()
        {
            using (var context = new TrashBinContext())
            {
                var enterprise = context.Companies.Single(c => c.EnterpriseId == Initializer.EnterpriseId);
                Assert.NotNull(enterprise);
                Assert.Equal("Software-Projects", enterprise.Name);
            }
        }
    }
}
