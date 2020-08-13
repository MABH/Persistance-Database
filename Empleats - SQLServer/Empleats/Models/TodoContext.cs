using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Empleats.Models
{
    public class TodoContext : DbContext
    {
        //public TodoContext(DbContextOptions<TodoContext> options)
            //: base(options){}
       public TodoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Empleat> Empleats { get; set; }
    }
}