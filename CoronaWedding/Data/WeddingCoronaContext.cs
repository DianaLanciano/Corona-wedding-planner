using CoronaWedding.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Data
{
    public class WeddingCoronaContext : DbContext
    {
        public WeddingCoronaContext(DbContextOptions<WeddingCoronaContext> options) : base(options)
        {
        }
        
        public DbSet<Account> Account  { get; set; }
        public DbSet<Catering> Catering { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Music> Music { get; set; }
        public DbSet<Photographer> Photographer { get; set; }


    }
}
