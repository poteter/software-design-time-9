using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;
using time9application.Entities;

namespace time9application.DatabaseMethods {
	internal class UpdateStudent {
		public static Student? UpdateStudentChangeName(int id, string name) {
			using SchoolDbContext db = new();

			Student? student = db.Student.SingleOrDefault(x => x.Id == id);
			if (student != null) {
				student.Name = name;
				db.Update(student);
				db.SaveChanges();
			}
			return student;
		}
	}
}
