using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Thulesson08CF.Models
{
    public class ThuBookStore : DbContext
    {
        public ThuBookStore() :base("ThuBookStoreConnectionString") { 
        }
        
            //tao cac bang 
        public DbSet<ThuCategory> ThuCategories{ get; set; }
        public DbSet<ThuBook> ThuBooks { get; set; }        
    }
}