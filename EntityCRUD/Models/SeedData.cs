using EntityCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EntityCRUD.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EntityCRUDContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<EntityCRUDContext>>()))
            {
                if (context.Users.Any())
                {
                    return;
                }

                context.Users.AddRange(
                
                    new Users
                    { 
                        name = "Max",
                        surname = "Kolonko",
                        email = "kolonko@gmail.com",
                        city = "Boston"
                    },

                    new Users
                    { 
                        name = "Andrzej",
                        surname = "Gołota",
                        email = "golota@gmail.com",
                        city = "Warszawa"
                    },

                    new Users
                    { 
                        name = "Piotr",
                        surname = "Żyła",
                        email = "zyla@gmail.com",
                        city = "Cieszyn"
                    },

                    new Users
                    { 
                        name = "Mariusz",
                        surname = "Pudzianowski",
                        email = "pudzian@gmail.com",
                        city = "Biała Rawska"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
