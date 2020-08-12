using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Salary
{
	// Input: Comma-delimited text file of employee salary data.
	// In this file, each line of data includes: Employee name, department, and salary.
	// Implement function GetDeptSalaryBudgets.
	// This function reads the file and computes the salary budget for each department
	// The data file can have any number of records and the parsed data is handled in memory, not persisted.
	class Program
	{
		static void Main(string[] args)
		{
			var salaryBudgets = GetDeptSalaryBudgets();
			foreach (Department key in salaryBudgets)
		    {
                Console.WriteLine(string.Format("Dept: {0} - Budget: {1}", key.Name, key.Budget));   
		    }

			Console.ReadLine();
		}

        // Refactor method to create desired return type.
		private static void GetDeptSalaryBudgets()
		{
			String line;
			using (StreamReader sr = new StreamReader(@"Data.txt"))
			{
				while ((line = sr.ReadLine()) != null)
				{
					// TODO: Implement parsing of data file.
				}
			}
		}

		class Department
		{
			public string Name { get; set; }
			public decimal Budget { get; set; }
		}
	}
}
