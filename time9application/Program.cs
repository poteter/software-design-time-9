using time9application.DataAccess.SqLite;
using time9application.Entities;

namespace time9application {
	internal class Program {
		static void Main() {
			int educationId = AddEducation();
			AddStudents(educationId);
			WriteEducationsToTerminal();
		}

		static void AddStudents(int id) {
			List<Student> students = new() {
			new() { Name = "wololo", EducationId = id },
			new() { Name = "woah", EducationId = id },
			new() { Name = "kaffe", EducationId = id },
			};

			using SchoolDbContext db = new();
			db.AddRange(students);
			db.SaveChanges();
		}


		static int AddEducation() {
			Education education = new() { Name = "Data Science" };
			using SchoolDbContext db = new();
			db.Education.Add(education);
			db.SaveChanges();
			return education.Id;
		}

		static void WriteEducationsToTerminal() {
			using SchoolDbContext db = new(); 

			IList<Education> educations = db.Education.ToList();
			foreach (var education in educations) {
                Console.WriteLine(education);
            }
		}
	}
}