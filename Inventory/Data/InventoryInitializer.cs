using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Data
{
	public class InventoryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InventoryContext>
	{
		protected override void Seed(InventoryContext context)
		{
			var customers = new List<Customer>
			{
			new Customer {FirstName="Antonio", LastName="Brown", LastPurchase=DateTime.Parse("2016-07-22")},
			new Customer {FirstName="Keenan", LastName="Allen", LastPurchase=DateTime.Parse("2016-07-05")},
			new Customer {FirstName="Alshon", LastName="Jeffery", LastPurchase=DateTime.Parse("2016-08-07")},
			new Customer {FirstName="Brandon", LastName="Marshall", LastPurchase=DateTime.Parse("2016-07-14")},
			new Customer {FirstName="Julio", LastName="Jones", LastPurchase=DateTime.Parse("2016-03-21")},
			new Customer {FirstName="Julian", LastName="Edelman", LastPurchase=DateTime.Parse("2016-07-24")}
			};

			customers.ForEach(s => context.Customers.Add(s));
			context.SaveChanges();

			var employees = new List<Employee>
			{
				new Employee {FirstName="Jay", LastName="Cutler", HireDate=DateTime.Parse("2016-08-02"), Salary=54000},
				new Employee {FirstName="Tom", LastName="Brady", HireDate=DateTime.Parse("2016-07-22"), Salary=48000},
				new Employee {FirstName="Aaron", LastName="Rodgers", HireDate=DateTime.Parse("2016-02-11"), Salary=63000},
				new Employee {FirstName="Matt", LastName="Ryan", HireDate=DateTime.Parse("2016-05-27"), Salary=28000},
				new Employee {FirstName="Cam", LastName="Newton", HireDate=DateTime.Parse("2016-07-03"), Salary=49000},
			};

			employees.ForEach(s => context.Employees.Add(s));
			context.SaveChanges();

			var departments = new List<Department>
			{
			new Department {Name="Music", TotalSales=0},
			new Department {Name="Movies", TotalSales=0},
			new Department {Name="Computers", TotalSales=0},
			new Department {Name="TVs", TotalSales=0},
			};
			departments.ForEach(s => context.Departments.Add(s));
			context.SaveChanges();

			var products = new List<Product>
			{
			new Product { Name="Anthrax - Bring the Noise", UPC=42286861128, Price=6.48m, Cost=3.45m, Description="3 TRACK PIC DISC B/W KEEP IT IN THE FAMILY AND I AM THE LAW 91", InventoryCount=3},
			new Product { Name="CybertronPC Electrum Gaming PC", UPC=844750024585, Price=599.00m, Cost=325.00m, Description="CybertronPC Electrum TGMELECTFXR70BR Gaming PC with AMD FX-4300 3.8GHz Processor,8GB DDR3 Memory,1TB Hard Drive,Radeon R7-360 Graphics,Windows 10", InventoryCount=5},
			new Product { Name="Dell i3656-3355BLK Desktop PC", UPC=884116203780, Price=679.00m, Cost=289.00m, Description="Dell i3656-3355BLK Desktop PC with AMD A10-8700P with R6 Processor ,8GB Memory,2TB Hard Drive,Radeon R9-360 Graphics,Windows 10", InventoryCount=2},
			new Product { Name="Sicario Blu-Ray", UPC=031398231851, Price=19.99m, Cost=11.29m, Description="", InventoryCount=1},
			new Product { Name=@"Samsung 65"" Class (64.5"" Actual Diagonal Size) KS9500 9-Series Curved 4K SUHD TV", UPC=887276139470, Price=3697.99m, Cost=2500.00m, Description="The Samsung KS9500 Curved 4K SUHD TV is an unparalleled blend of form and function. Its Quantum Dot Color envelops you in our best picture yet, allowing you to escape into whatever you're watching. Supreme UHD Dimming dramatically improves color and contrast, while Supreme Motion Rate 240 captures action that leaves your heart pounding. We've enhanced everything from its curved screen to its seamless Smart TV capabilities. The ultimate viewing experience has arrived. ", InventoryCount=47},
			};
			products.ForEach(s => context.Products.Add(s));
			context.SaveChanges();

			var transactions = new List<Transaction>
			{
				new Transaction {TransactionID=1, ID=1, Date=DateTime.Parse("2016-08-03"), Total=6.48m }
			};
		}
	}
}