using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcChef.Models;

namespace MvcChef.Data
{
    public class MvcChefContext : DbContext
    {
        public MvcChefContext (DbContextOptions<MvcChefContext> options)
            : base(options)
        {
        }

        public DbSet<MvcChef.Models.Chef> Chef { get; set; }
    }
}
