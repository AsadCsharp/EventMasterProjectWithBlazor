using EventMasterProjectShared;
using Microsoft.EntityFrameworkCore;

namespace EventMasterProjectServer.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
