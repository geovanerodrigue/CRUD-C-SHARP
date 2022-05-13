using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanhouse.Hydra.Models
{
    public class UsuarioContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public UsuarioContexto()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=lanhouse;Uid=root;Pwd=180897",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
    }
}
