using MicroDynamicWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroDynamicWebAPI.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<DynamicObject> DynamicObjects { get; set; }
       
    }
}
