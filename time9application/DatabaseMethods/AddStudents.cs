using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;
using time9application.Entities;

namespace time9application.DatabaseMethods {
	internal class AddStudents {
		public static void Add(int id) {
			List<Student> students = new() {
			new() { Name = "wololo", EducationId = id },
			new() { Name = "woah", EducationId = id },
			new() { Name = "kaffe", EducationId = id },
			};

			using SchoolDbContext db = new();
			db.AddRange(students);
			db.SaveChanges();
		}
	}
}
