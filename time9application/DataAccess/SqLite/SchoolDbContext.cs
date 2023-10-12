using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.Entities;

namespace time9application.DataAccess.SqLite
{
    internal class SchoolDbContext : DbContext
    {
        public DbSet<Student> Student => Set<Student>();
        public DbSet<Education> Education => Set<Education>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(@"Data Source = Resources\School.db");
		}
	}
}
