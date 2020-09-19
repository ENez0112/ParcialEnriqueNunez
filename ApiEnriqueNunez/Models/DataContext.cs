using System.Data.Entity;

namespace ApiEnriqueNunez.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiEnriqueNunez.Models.Country> Countries { get; set; }
    }
}