using System;
using System.Collections.Generic;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public abstract class Employee
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double BaseSalary { get; set; }

        public Employee() { }

        public Employee(string employeeID, string name, string position, double baseSalary)
        {
            EmployeeID = employeeID;
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateMonthlySalary(List<AttendanceRecord> attendance, List<TaskAssignment> tasks, int month, int year);
    }
}
