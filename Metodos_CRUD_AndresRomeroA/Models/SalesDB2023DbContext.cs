using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_CRUD_AndresRomeroA.Models
{
   
    
        public class SalesDB2023DbContext : DbContext
        {
            public DbSet<Cliente> clientes { get; set; }
          

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FOROCRUD;Trusted_Connection=True;");
            }
        }
    
}
