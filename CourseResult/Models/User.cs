using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseResult.Models
{
	public class User
	{
		[Key]
		[MinLength(2)]
		[MaxLength(100)]
		public string Nickname { get; set; }
		[Required]
		[MaxLength(100)]
		public string Email { get; set; }
		[Required]
		[MinLength(6)]
		[MaxLength(30)]
		public string Password { get; set; } 

		public List<Overview> Overviews { get; set; }
	}
}
