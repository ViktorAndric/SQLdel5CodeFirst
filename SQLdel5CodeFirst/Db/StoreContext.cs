using Microsoft.EntityFrameworkCore;
using SQLdel5CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLdel5CodeFirst.Db
{
	internal class StoreContext : DbContext
	{
		public DbSet<Product> _products { get; set; }
		public  DbSet<Category> _categories { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLdel5CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}
	}
}
