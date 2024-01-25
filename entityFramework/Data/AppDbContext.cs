using entityFramework.Models;
using Microsoft.EntityFrameworkCore;
namespace entityFramework.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options) { }

		public DbSet<Product> Products { get; set; } // folosim ce am creat in models


	} 
}

