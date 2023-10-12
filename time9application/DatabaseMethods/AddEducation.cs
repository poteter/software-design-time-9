using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using time9application.DataAccess.SqLite;
using time9application.Entities;

namespace time9application.DatabaseMethods {
	internal class AddEducation {
		static int Add() {
			Education education = new() { Name = "Data Science" };
			using SchoolDbContext db = new();
			db.Education.Add(education);
			db.SaveChanges();
			return education.Id;
		}
	}
}
