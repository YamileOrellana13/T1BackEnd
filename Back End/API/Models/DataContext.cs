using System.Data.Entity;
namespace API.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API.Models.Product> Products { get; set; }
    }
}