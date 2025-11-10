using System;
using System.Windows.Forms;
using _4_ChamCong_DeTaiCuoiKi.modal;
using _4_ChamCong_DeTaiCuoiKi.form;
using System.Drawing;

namespace _4_ChamCong_DeTaiCuoiKi.form
{
    public partial class MainForm : Form
    {
        private Company company;

        public MainForm()
        {
            InitializeComponent();

            // Full screen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            StyleDataGridView(dgvEmployees);

            company = new Company();
            RefreshEmployeeGrid();
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.GridColor = Color.Gray;
            dgv.BackgroundColor = Color.WhiteSmoke;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void RefreshEmployeeGrid()
        {
            dgvEmployees.Rows.Clear();
            foreach (var emp in company.Employees)
            {
                dgvEmployees.Rows.Add(emp.EmployeeID, emp.Name, emp.Position, emp.GetType().Name);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm form = new AddEditEmployeeForm(company);
            form.ShowDialog();
            RefreshEmployeeGrid();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0) return;
            string empID = dgvEmployees.SelectedRows[0].Cells[0].Value.ToString();
            var emp = company.Employees.Find(e1 => e1.EmployeeID == empID);
            if (emp != null)
            {
                AddEditEmployeeForm form = new AddEditEmployeeForm(company);
                form.LoadEmployee(emp);
                form.ShowDialog();
                RefreshEmployeeGrid();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0) return;
            string empID = dgvEmployees.SelectedRows[0].Cells[0].Value.ToString();
            var emp = company.Employees.Find(e1 => e1.EmployeeID == empID);
            if (emp != null)
            {
                company.RemoveEmployee(emp);
                RefreshEmployeeGrid();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            company.Employees.Clear();
            company.AttendanceRecords.Clear();
            company.TaskAssignments.Clear();
            RefreshEmployeeGrid();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm form = new AttendanceForm(company);
            form.ShowDialog();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollForm form = new PayrollForm(company);
            form.ShowDialog();
        }

        private void btnGenerateSample_Click(object sender, EventArgs e)
        {
            company.GenerateSampleEmployees(1000); // tạo 1000 nhân viên demo
            RefreshEmployeeGrid();
        }
        private void btnRandomAttendance_Click(object sender, EventArgs e)
        {
            if (company.Employees.Count == 0)
            {
                MessageBox.Show("Danh sách nhân viên đang trống!");
                return;
            }

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            company.GenerateRandomAttendance(month, year); // gọi hàm có sẵn

            MessageBox.Show("Đã chấm công ngẫu nhiên cho tất cả nhân viên!");
        }

    }
}
