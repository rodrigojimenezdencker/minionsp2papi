using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIMinionsP2P.Models;

namespace APIMinionsP2P.Models
{
    public class APIMinionsP2PContext : DbContext
    {
        public APIMinionsP2PContext (DbContextOptions<APIMinionsP2PContext> options)
            : base(options)
        {
        }

        public DbSet<APIMinionsP2P.Models.User> Deudor { get; set; }

        public DbSet<APIMinionsP2P.Models.Loan> Loan { get; set; }
    }
}
