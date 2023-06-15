using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }// Bu şu demek: Benim bir <Product>'um var onu entity seti olarak yani tablo gibi Products ismiyle kullanacağım. Bu kod veritabanı tablolarında Products diye bir şey arıyor.
    }
}
