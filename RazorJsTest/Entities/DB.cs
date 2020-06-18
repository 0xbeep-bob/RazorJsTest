using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using RazorJsTest.Entities.Helpers;
using RazorJsTest.Entities.Tables;
using System;
using System.IO;
using System.Reflection;

namespace RazorJsTest.Entities
{
    public class DB : DbContext
    {
        public DbSet<Counter> Counters { get; set; }

        public DB()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqliteConnectionStringBuilder()
            {
                DataSource = Path.Combine(AppContext.BaseDirectory, "RazorJsTest.db"),
                Cache = SqliteCacheMode.Shared,
                Mode = SqliteOpenMode.ReadWriteCreate,
            };
            optionsBuilder.UseSqlite(builder.ConnectionString, options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Counter>()                
                .HasData(FillTablesHelper.Instance.FillCounters());

            base.OnModelCreating(modelBuilder);
        }
    }
}
