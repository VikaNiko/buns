using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace server_bakery.Models
{

        public class ApplicationContext : DbContext
        {
            public DbSet<Bun> Buns { get; set; }
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
           //Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
            }
        }
    
}
