using Mediatheque.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Mediatheque.Dal
{
    public class GameContext : DbContext
    {
        public GameContext() : base("GameContext")
        {
        }

        public DbSet<Games> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //empêche l’en cours mis au pluriel des noms de table
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        private static GameContext _context = new GameContext();
        public static GameContext Context { get => _context; set => _context = value; }
    }
}