

namespace MVC.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC.Models.Product> Products { get; set; }
    }
}