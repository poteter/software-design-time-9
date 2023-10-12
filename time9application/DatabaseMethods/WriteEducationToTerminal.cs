using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;
using time9application.Entities;

namespace time9application.DatabaseMethods {
	internal class WriteEducationToTerminal {
		public static void Write() {
			using SchoolDbContext db = new();

			IList<Education> educations = db.Education.ToList();
			foreach (var education in educations) {
				Console.WriteLine(education);
			}
		}
	}
}
