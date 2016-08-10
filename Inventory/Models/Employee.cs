using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
	public class Employee : Person
	{
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Hire Date")]
		public DateTime HireDate { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "money")]
		public decimal Salary { get; set; }

		public virtual ICollection<Department> Departments { get; set; }
	}
}