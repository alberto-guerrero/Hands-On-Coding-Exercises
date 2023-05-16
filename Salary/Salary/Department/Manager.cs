using Salary.ConsoleWrapper;
using System;
using System.IO;
using NUnit.Framework;

namespace Salary.Department
{
    // Input: Comma-delimited text file of employee salary data.
    // In this file, each line of data includes: Employee name, department, and salary.
    // Implement function GetBudgets.
    // This function reads the file and computes the salary budget for each department
    // The data file can have any number of records and the parsed data is handled in memory, not persisted.
    // Implement unit test, use mocking when needed

    /// <summary>
    /// Department Salaries Manager.
    /// </summary>
    public class Manager
    {
        private readonly IConsole _console;

        /// <summary>
        /// CTOR.
        /// </summary>
        public Manager()
        {
            _console = new ConsoleWrapper.Console();
        }

        /// <summary>
        /// CTOR for mocking.
        /// </summary>
        /// <param name="console"></param>
        internal Manager(IConsole console)
        {
            _console = console;
        }

        // TODO: Fix the compilation error.
        // TODO: Implement unit tests
        /// <summary>
        /// Prints the department salaries budgets.
        /// </summary>
        public virtual void PrintBudgets()
        {
            var salaryBudgets = GetBudgets();
            foreach (Department key in salaryBudgets)
            {
                _console.WriteLine(string.Format("Dept: {0} - Budget: {1}", key.Name, key.Budget));   
            }
        }

        // TODO: Refactor method to create desired return type.
        // TODO: Implement unit tests
        /// <summary>
        /// Gets the department salaries budgets.
        /// </summary>
        internal virtual void GetBudgets()
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
    }

    /// <summary>
    /// Represents a Department.
    /// </summary>
    internal class Department
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
    }

    [TestFixture]
    public class PrintBudgetsFixture
    {
        // TODO: implement tests
        // mock the call to GetBudgets
        // mock IConsole

        // Moq nuget package was added to the Solution
        // If you would like to use another mocking framework, add its nugget reference

        [Test]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
    
    [TestFixture]
    public class GetBudgetsFixture
    {
        // TODO: implement tests
        // use Data.txt as source of data

        [Test]
        public void Test()
        {
            // Arrange

            // Act

            // Assert

            // Resulting data structure must be ordered by Department alphabetically
            // First item should be Engineering with a total of 195000
            // Second item should be HR with a total of 132000
            // Third item should be Sales with a total of 145000
        }
    }
}
