using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    using System.Data.Entity;
    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Sale> Sales { get; set; }
    }
}