using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telemed.Model
{
    public class TemperatureContext : DbContext
    {
        public DbSet<Temperature> Temperatures { get; set; }
        public TemperatureContext(DbContextOptions<TemperatureContext> options)
            : base(options)
        {}
    }
}
