using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
	public class Product
	{
		[Key]
		public Int64 UPC { get; set; }
		public string Name { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "money")]
		public decimal Price { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "money")]
		public decimal Cost { get; set; }

		public string Description { get; set; }

		public int InventoryCount { get; set; }
	}
}