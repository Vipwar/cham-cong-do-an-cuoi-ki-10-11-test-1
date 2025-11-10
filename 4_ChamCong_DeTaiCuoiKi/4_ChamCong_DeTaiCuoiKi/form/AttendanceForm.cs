using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _4_ChamCong_DeTaiCuoiKi.modal;

namespace _4_ChamCong_DeTaiCuoiKi.form
{
    public partial class AttendanceForm : Form
    {
        private Company company;
        private int month;
        private int year;

        public AttendanceForm(Company company)
        {
            InitializeComponent();
            this.company = company;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            StyleDataGridView(dgvAttendance);

            month = DateTime.Now.Month;
            year = DateTime.Now.Year;

            InitializeAttendanceGrid();
            RefreshAttendanceGrid();
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

        private void InitializeAttendanceGrid()
        {
            if (dgvAttendance.Columns.Count == 0)
            {
                dgvAttendance.Columns.Add("EmployeeID", "Mã NV");
                dgvAttendance.Columns.Add("Name", "Tên NV");
                dgvAttendance.Columns.Add("Position", "Chức vụ");
                dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "IsPresent", HeaderText = "Đi làm" });
            }
        }

        private void RefreshAttendanceGrid()
        {
            dgvAttendance.Rows.Clear();
            foreach (Employee emp in company.Employees)
            {
                dgvAttendance.Rows.Add(emp.EmployeeID, emp.Name, emp.Position, false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                string empID = row.Cells[0].Value?.ToString() ?? "";
                string name = row.Cells[1].Value?.ToString() ?? "";
                string position = row.Cells[2].Value?.ToString() ?? "";
                bool isPresent = Convert.ToBoolean(row.Cells[3].Value ?? false);

                AttendanceRecord record = new AttendanceRecord(empID, new DateTime(year, month, 1), isPresent, name, position);
                company.AddAttendanceRecord(record);
            }

            MessageBox.Show("Đã lưu chấm công!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
