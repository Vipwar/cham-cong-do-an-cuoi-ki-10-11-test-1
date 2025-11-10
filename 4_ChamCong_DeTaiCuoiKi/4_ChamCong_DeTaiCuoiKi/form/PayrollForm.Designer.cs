using System;
using System.Windows.Forms;

namespace _4_ChamCong_DeTaiCuoiKi.form
{
    partial class PayrollForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();

            // dgvPayroll
            this.dgvPayroll.Location = new System.Drawing.Point(12, 50);
            this.dgvPayroll.Size = new System.Drawing.Size(900, 400);
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (this.dgvPayroll.Columns.Count == 0)
            {
                dgvPayroll.Columns.Add("EmployeeID", "Mã NV");
                dgvPayroll.Columns.Add("Name", "Họ và tên");
                dgvPayroll.Columns.Add("Position", "Chức vụ");
                dgvPayroll.Columns.Add("Type", "Loại NV");
                dgvPayroll.Columns.Add("BaseSalary", "Lương cơ bản");
                dgvPayroll.Columns.Add("PresentDays", "Số ngày đi làm");
                dgvPayroll.Columns.Add("TaskCount", "Số task");
                dgvPayroll.Columns.Add("Bonus", "Thưởng");
                dgvPayroll.Columns.Add("TotalSalary", "Tổng lương");
                dgvPayroll.Columns.Add("ContractDuration", "Tháng hợp đồng");
            }

            // numMonth
            this.numMonth.Location = new System.Drawing.Point(60, 12);
            this.numMonth.Minimum = 1;
            this.numMonth.Maximum = 12;
            this.numMonth.Value = DateTime.Now.Month;

            // lblMonth
            this.lblMonth.Location = new System.Drawing.Point(12, 12);
            this.lblMonth.Size = new System.Drawing.Size(50, 20);
            this.lblMonth.Text = "Tháng:";

            // numYear
            this.numYear.Location = new System.Drawing.Point(180, 12);
            this.numYear.Minimum = 2000;
            this.numYear.Maximum = 2100;
            this.numYear.Value = DateTime.Now.Year;

            // lblYear
            this.lblYear.Location = new System.Drawing.Point(140, 12);
            this.lblYear.Size = new System.Drawing.Size(40, 20);
            this.lblYear.Text = "Năm:";

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(300, 10);
            this.btnRefresh.Size = new System.Drawing.Size(100, 25);
            this.btnRefresh.Text = "Xem bảng lương";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(820, 460);
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // PayrollForm
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Name = "PayrollForm";
            this.Text = "Bảng lương chi tiết";

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
