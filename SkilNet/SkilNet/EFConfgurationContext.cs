using Microsoft.EntityFrameworkCore;

namespace SkilNet
{
    public class EFConfigurationContext : DbContext
    {
        public EFConfigurationContext(DbContextOptions<EFConfigurationContext> options) : base(options)
        {
        }

        public DbSet<EFConfigurationValue> Values => Set<EFConfigurationValue>();
    }
}
