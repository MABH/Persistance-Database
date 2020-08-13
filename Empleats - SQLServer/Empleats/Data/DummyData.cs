using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empleats.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Empleats.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TodoContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any ailments
                if (context.Empleats != null && context.Empleats.Any())
                    return;   // DB has already been seeded

                var empleats = GetEmpleats().ToArray();
                context.Empleats.AddRange(empleats);
                context.SaveChanges();                
            }
        }

        public static List<Empleat> GetEmpleats()
        {
            List<Empleat> empleats = new List<Empleat>() {
                new Empleat {   Nom="Nom1",
                                Cognom="Cognom",
                                Carrec="Carrec",
                                Sou=10}                
            };
            return empleats;
        }

    }
}
