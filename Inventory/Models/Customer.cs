using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
	public class Customer : Person
	{
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Last Purchase")]
		public DateTime LastPurchase { get; set; }

		public virtual ICollection<Transaction> Transactions { get; set; }
	}
}