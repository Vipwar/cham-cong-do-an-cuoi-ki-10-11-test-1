using System;
using System.Collections.Generic;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public class ContractEmployee : Employee
    {
        public int ContractDurationMonths { get; set; }

        public ContractEmployee() : base() { ContractDurationMonths = 0; }

        public ContractEmployee(string employeeID, string name, string position, double baseSalary, int contractDurationMonths)
            : base(employeeID, name, position, baseSalary)
        {
            ContractDurationMonths = contractDurationMonths;
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
            return BaseSalary * presentDays / 22.0;
        }
    }
}
