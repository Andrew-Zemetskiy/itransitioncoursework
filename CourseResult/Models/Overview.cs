using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseResult.Models
{
	public class Overview
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Category { get; set; }
		[Required]
		[MinLength(10)]
		[MaxLength(100)]
		public string Title { get; set; }
		[Required]
		[MinLength(20)]
		[MaxLength(3000)]
		public string Content { get; set; }
		[Required]
		[MinLength(2)]
		[MaxLength(100)]
		public string Creator { get; set; }
		[Required]
		[Range(0,10)]
		public int Grade { get; set; }

		public User Users { get; set; }
	}
}
