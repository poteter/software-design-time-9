using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;
using time9application.Entities;

namespace time9application.DatabaseMethods {
	internal class AddTeacher {
		public static void Add(int educationId) {
			List<Teacher> teachers = new() {
			new() { Name = "Roland", EducationId = educationId },
			new() { Name = "William", EducationId = educationId },
			new() { Name = "roti", EducationId = educationId },
			};

			using SchoolDbContext db = new();
			db.AddRange(teachers);
			db.SaveChanges();
		}
	}
}
