using System;
using System.Collections.Generic;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager() : base() { Department = ""; }

        public Manager(string employeeID, string name, string position, double baseSalary, string department)
            : base(employeeID, name, position, baseSalary)
        {
            Department = department;
        }

        public override double CalculateMonthlySalary(List<AttendanceRecord> attendance, List<TaskAssignment> tasks, int month, int year)
        {
            int presentDays = 0;
            if (attendance != null)
            {
                foreach (var record in attendance)
                {
                    if (record.EmployeeID == EmployeeID &&
                        record.Date.Month == month &&
                        record.Date.Year == year &&
                        record.IsPresent)
                        presentDays++;
                }
            }

            double basePay = BaseSalary * presentDays / 22.0;
            double bonus = tasks != null ? tasks.Count * 200000 : 0;

            return basePay + bonus;
        }
    }
}
