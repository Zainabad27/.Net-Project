using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zroject.Models;

namespace Zroject.Data
{
    public class ClubMemberShipDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {




            optionsBuilder.UseSqlite($"Data source={AppDomain.CurrentDomain.BaseDirectory}ClubMemberShipDbContext.db");

            base.OnConfiguring(optionsBuilder);

        }


        public DbSet<User> UserModel { get; set; }
    }
}
