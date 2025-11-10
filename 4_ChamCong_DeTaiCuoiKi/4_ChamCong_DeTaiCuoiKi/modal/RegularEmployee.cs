using System;
using System.Collections.Generic;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public class RegularEmployee : Employee
    {
        public RegularEmployee() : base() { }

        public RegularEmployee(string employeeID, string name, string position, double baseSalary)
            : base(employeeID, name, position, baseSalary) { }

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
            return BaseSalary * presentDays / 22.0;
        }
    }
}
