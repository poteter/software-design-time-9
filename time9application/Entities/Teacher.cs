using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time9application.Entities {
	internal class Teacher {
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int EducationId { get; set; }

		public override string ToString() {
			return $"Id: {Id}\nName: {Name}";
		}
	}
}
