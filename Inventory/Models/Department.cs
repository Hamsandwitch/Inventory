﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
	public class Department
	{
		public int DepartmentID { get; set; }

		[StringLength(64, MinimumLength = 1)]
		public string Name { get; set; }

		public virtual ICollection<Employee> Managers { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "money")]
		public decimal TotalSales { get; set; }

	}
}