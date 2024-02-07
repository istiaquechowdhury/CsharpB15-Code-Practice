using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionstring;

        public ApplicationDbContext()
        {
            _connectionstring = "Server = DESKTOP-QVPOJIS\\SQLEXPRESS; Database = CsharpB15; User Id = CsharpB15; Password = 123456; Trust Server Certificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connectionstring);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }

    }
}
