using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Inventory.Data
{
	public class InventoryContext : DbContext
	{
		public InventoryContext() : base("InventoryContext")
		{
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
	}
}