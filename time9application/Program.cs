using Microsoft.EntityFrameworkCore;
using time9application.DataAccess.SqLite;
using time9application.Entities;
using time9application.DatabaseMethods;

namespace time9application {
	internal class Program {
		static void Main() {
			// int educationId = AddEducation();
			// AddStudents(educationId);
			// AddTeacher(educationId);
			// WriteEducationsToTerminal();
			// ReadAllStudentNames();
			// ReadEducationAndStudents("Data Science");
			// ReadAllStudentNames();
			// UpdateStudentChangeName(4, "I Changed This One");
			 ReadAllStudentNames.Read();
			//DeleteStudent(3);
			// ReadAllStudentNames();
		}
	}
}