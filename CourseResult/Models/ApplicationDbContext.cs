using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseResult.Models
{
	public class ApplicationDbContext :DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Overview> Overviews { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	   : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
