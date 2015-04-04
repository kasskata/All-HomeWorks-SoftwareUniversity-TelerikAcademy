using System;
using System.Linq;

namespace _01.DbContextForTheSoftUniDB
{
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var db = new SoftUniEntities();
            var firstId = 0;

            //EmployeeID	FirstName	LastName	MiddleName	JobTitle	DepartmentID	ManagerID	HireDate	Salary	AddressID
            for (int i = 314; i <= 317; i++)
            {
                InsertNewEmployee(db, "Sashko", "Sashev", "Sashev", "Production Technician", "Engineering", "svetlin nakov", DateTime.Now, 1234.32, "108 Lakeside Court");
                firstId = i;
            }

            for (int i = firstId; i <= firstId+3; i++)
            {
                ModifyEmployee(db, i, "Pesho", "Georgiev", "Minchev", "Production Technician", "Engineering", "svetlin nakov", DateTime.Now.AddYears(-10), 187235.32, "108 Lakeside Court");
            }


            for (int i = firstId; i <= firstId+3; i++)
            {
                DeleteEmployee(db, i);
            }

            var employeesWithProjects = ListAllEmployeeWithProjectSQL(db).OrderByDescending(e => e.Projects.Count);

            foreach (var employee in employeesWithProjects)
            {
                Console.WriteLine("|{0,-5}|{1,-20}|{2,-15}|{3,-15}|{4,-25}|{5,-5}|{6,-40}|",
                    employee.EmployeeID,
                    employee.FirstName,
                    employee.LastName,
                    employee.Salary,
                    employee.JobTitle,
                    employee.Projects.Count,
                    employee.Address.AddressText);
                Console.WriteLine(new string('-', 150));
            }

            SelectAllManagersByDept(db, "Research and Development", "Ken Sanchez");

        }

        //2.Your task is to create a Data Access Object class with static methods which provides functionality for inserting, modifying and deleting employees. Write a testing class.
        #region

        private static void DeleteEmployee(SoftUniEntities db, int id)
        {
            var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        private static void ModifyEmployee(SoftUniEntities db, int id, string firstName, string lastName,
            string middleName, string jobTitle, string department, string manager, DateTime dateTime, double salary,
            string address)
        {
            var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                throw new NullReferenceException();
            }
            employee.DepartmentID = db.Departments.FirstOrDefault(d => d.Name == department).DepartmentID;
            employee.ManagerID = db.Employees.FirstOrDefault(e => e.FirstName + " " + e.LastName == manager).EmployeeID;
            employee.AddressID = db.Addresses.FirstOrDefault(a => a.AddressText == address).AddressID;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.MiddleName = middleName;
            employee.Salary = (decimal)salary;
            employee.HireDate = dateTime;
            employee.JobTitle = jobTitle;

            db.Entry(db.Employees.FirstOrDefault(e => e.EmployeeID == id)).CurrentValues.SetValues(employee);
            db.SaveChanges();
        }

        private static void InsertNewEmployee(SoftUniEntities db, string firstName, string lastName, string middleName,
            string jobTitle, string department, string manager, DateTime dateTime, double salary, string address)
        {
            var idDepartment = db.Departments.FirstOrDefault(d => d.Name == department).DepartmentID;
            var idManager = db.Employees.FirstOrDefault(e => e.FirstName + " " + e.LastName == manager).EmployeeID;
            var idAddress = db.Addresses.FirstOrDefault(a => a.AddressText == address).AddressID;

            var newEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName,
                AddressID = idAddress,
                ManagerID = idManager,
                DepartmentID = idDepartment,
                JobTitle = jobTitle,
                HireDate = dateTime,
                Salary = (decimal)salary
            };

            db.Employees.Add(newEmployee);
            db.SaveChanges();
        }

        #endregion

        //03. finds employees with projects
        private static List<Employee> ListAllEmployeeWithProject(SoftUniEntities db)
        {
            var employees = db.Employees.Where(e => e.Projects.Count != 0).ToList();

            return employees;
        }

        //04.Implement previous by using native SQL query
        private static List<Employee> ListAllEmployeeWithProjectSQL(SoftUniEntities db)
        {
            List<Employee> employees;
            //BOOM!! in MSSQL Doesn't blow
            employees = db.Employees.SqlQuery("SELECT COUNT(Name), FirstName + ' ' + LastName FROM Employees JOIN EmployeesProjects ON Employees.EmployeeID = EmployeesProjects.EmployeeID JOIN Projects ON EmployeesProjects.ProjectID = Projects.ProjectID GROUP BY FirstName + ' ' + LastName ORDER BY COUNT(Name) DESC").ToList();
            return employees;
        }

        //05.Your task is to write a method that finds all employees by specified department (name) and manager (first name and last name).
        private static void SelectAllManagersByDept(SoftUniEntities db, string departmentName, string fullName)
        {
            var managerId = db.Employees.FirstOrDefault(m => m.ManagerID == null && m.FirstName + " " + m.LastName == fullName).EmployeeID;
            var departmentId = db.Departments.FirstOrDefault(d => d.Name == departmentName).DepartmentID;
            var employees = db.Employees.Where(e => e.DepartmentID == departmentId && e.ManagerID == managerId);

            foreach (var manager in employees)
            {
                Console.WriteLine(manager.FirstName + " " + manager.LastName);
            }
        }
    }
}
