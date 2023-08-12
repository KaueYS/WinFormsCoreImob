
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsCoreImob.Context
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(): base(@"Data Source=KAUE\SQLEXPRESS;Initial Catalog=WINFORMCOREDB11;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
        public DbSet<ClienteImovel> ClientesImoveis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteImovelMap());
        }

    }
}
