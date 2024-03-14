using HRAdministrationAPI;
using System;

namespace SchoolHRAdministration
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster
    }

    class Programm
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            //   foreach ( IEmployee employee in employees)
            //   {
            //       totalSalaries += employee.Salary;
            //   }

            //   Console.WriteLine($"Total Salary (including bonus) : {totalSalaries}");

            Console.WriteLine($"Total Salary (including bonus) : {employees.Sum(x => x.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Par", "Afl", 40000);
            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Arm", "Ahm", 5000);
            IEmployee headDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Dan", "Saj", 6000);
            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Hos", "Saj", 4000);
            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Mam", "zan", 7000);
            employees.Add(teacher1);
            employees.Add(teacher2);
            employees.Add(headDepartment);
            employees.Add(headMaster);
            employees.Add(deputyHeadMaster);
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }

    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }


    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }


    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }


    }

    public static class EmployeeFactory
    {

        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            IEmployee employee = null;
            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = new Teacher
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                    ;
                case EmployeeType.DeputyHeadMaster:
                    employee = new DeputyHeadMaster
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                    ;
                case EmployeeType.HeadMaster:
                    employee = new HeadMaster
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                    ;

                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                default:
                    break;
            }
            return employee;
        }
    }


   }
