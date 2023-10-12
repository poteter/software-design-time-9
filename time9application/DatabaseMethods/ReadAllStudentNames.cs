using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;

namespace time9application.DatabaseMethods {
	internal class ReadAllStudentNames {
		public static void Read() {
			using SchoolDbContext db = new();
			IList<string> studentNames = db.Student.Select(x => x.Name).ToList();

			foreach (string name in studentNames) {
				Console.WriteLine(name);
			}
		}
	}
}
