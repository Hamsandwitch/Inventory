using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
	public abstract class Person
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[StringLength(64)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[StringLength(64, ErrorMessage = "First name cannot be longer than 64 characters.")]
		[Column("FirstName")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Full Name")]
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
	}
}