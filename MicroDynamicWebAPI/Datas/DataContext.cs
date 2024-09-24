using MicroDynamicWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroDynamicWebAPI.Datas
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
                
        }
        public DbSet<DynamicObject> DynamicObjects { get; set; }
    }
}
