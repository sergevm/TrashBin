using System.Data.Entity;

namespace TrashBin.Domain
{
    public class TrashBinContext : DbContext 
    {
        public TrashBinContext() : base("TrashBin")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Enterprise> Companies { get; set; }
    }
}
