using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslateBot.Models;

namespace TranslateBot.Data
{
    public class LocalDbContext:DbContext
    {
        public DbSet<Phrase> Local { get; set; }

        public LocalDbContext (DbContextOptions<LocalDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phrase>().ToTable("Phrases");

        }
    }
}
