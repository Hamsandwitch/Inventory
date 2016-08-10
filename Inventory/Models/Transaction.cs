using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
	public class Transaction
	{
		public int TransactionID { get; set; }
		public int ID { get; set; } // Customer's ID

		[DataType(DataType.Currency)]
		[Column(TypeName = "money")]
		public decimal Total { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Date")]
		public DateTime Date { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}