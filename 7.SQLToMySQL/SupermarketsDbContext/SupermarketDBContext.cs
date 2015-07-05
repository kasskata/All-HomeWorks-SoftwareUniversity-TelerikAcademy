using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SupermarketsDbContext
{
    public class SupermarketDBContext : DbContext
    {
        public SupermarketDBContext()
            : base("name=MySQLSupermarkets")
        {
        }

        public IDbSet<Measure> Мeasures { get; set; }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Supermarket> Supermarkets { get; set; }

        public IDbSet<Supermarket_Sales> SupermarketSales { get; set; }

        public IDbSet<SupermarketProduct> SupermarketProducts { get; set; }

        public IDbSet<Vendor> Vendors { get; set; }

        public IDbSet<Expens> Expensеs { get; set; }
    }
}
