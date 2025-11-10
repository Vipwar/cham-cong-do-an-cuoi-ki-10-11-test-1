using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4_ChamCong_DeTaiCuoiKi.modal;

namespace _4_ChamCong_DeTaiCuoiKi.form
{
    public partial class PayrollForm : Form
    {
        private Company company;

        public PayrollForm(Company company)
        {
            InitializeComponent();
            this.company = company;

            numMonth.Value = DateTime.Now.Month;
            numYear.Value = DateTime.Now.Year;

            LoadPayrollData((int)numMonth.Value, (int)numYear.Value);
        }

        private void LoadPayrollData(int month, int year)
        {
            dgvPayroll.Rows.Clear();

            foreach (Employee emp in company.Employees)
            {
                int presentDays = company.GetAttendanceCount(emp.EmployeeID, month, year);
                int taskCount = company.GetTaskCount(emp.EmployeeID, month, year);

                double totalSalary = emp.CalculateMonthlySalary(
                    company.GetAttendanceByEmployee(emp.EmployeeID, month, year),
                    company.GetTasksByEmployee(emp.EmployeeID, month, year),
                    month,
                    year
                );

                string type = emp.GetType().Name;
                int contractDuration = (emp is ContractEmployee cEmp) ? cEmp.ContractDurationMonths : 0;

                dgvPayroll.Rows.Add(
                    emp.EmployeeID,
                    emp.Name,
                    emp.Position,
                    type,
                    emp.BaseSalary,
                    presentDays,
                    taskCount,
                    taskCount * 200000,
                    totalSalary,
                    contractDuration
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPayrollData((int)numMonth.Value, (int)numYear.Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
