using Microsoft.EntityFrameworkCore;
using System;

namespace Cyrsovay.Models
{
    public class Context : DbContext
    {
        public DbSet<TextModel> Cyrsach { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
