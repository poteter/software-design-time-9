using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;
using time9application.Entities;
using Microsoft.EntityFrameworkCore;


namespace time9application.DatabaseMethods {
	internal class ReadEducationAndStudents {
		public static void Read(string educationName) {
			using SchoolDbContext db = new();

			Education? education = db.Education
				.Include(e => e.Students)
				.Include(e => e.Teachers)
				.FirstOrDefault(e => e.Name == $"{educationName}");

			if (education != null && education.Teachers != null && education.Students != null) {
				Console.WriteLine($"Education:\nID: {education.Id}\nName: {education.Name}\n");
				Console.WriteLine("Teacher(s):");
				foreach (Teacher teacher in education.Teachers) {
					Console.WriteLine($"Id: {teacher.Id}\nName: {teacher.Name}\n");
				}

				Console.WriteLine("Student(s):");
				foreach (Student student in education.Students) {
					Console.WriteLine($"\nStudent id: {student.Id}\nName: {student.Name}");
				}
			}
		}
	}
}
