using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityCRUD.Models;

namespace EntityCRUD.Data
{
    public class EntityCRUDContext : DbContext
    {
        public EntityCRUDContext (DbContextOptions<EntityCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<EntityCRUD.Models.Users> Users { get; set; }
    }
}
