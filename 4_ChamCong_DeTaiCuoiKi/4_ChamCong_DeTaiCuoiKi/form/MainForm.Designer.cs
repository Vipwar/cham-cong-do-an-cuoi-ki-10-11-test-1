namespace _4_ChamCong_DeTaiCuoiKi.form
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnRandomAttendance;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnGenerateSample;

        private void InitializeComponent()
        {
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnRandomAttendance = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnGenerateSample = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();

            // dgvEmployees
            this.dgvEmployees.Location = new System.Drawing.Point(20, 20);
            this.dgvEmployees.Size = new System.Drawing.Size(1200, 500);
            this.dgvEmployees.Columns.Add("EmployeeID", "ID");
            this.dgvEmployees.Columns.Add("Name", "Tên");
            this.dgvEmployees.Columns.Add("Position", "Chức vụ");
            this.dgvEmployees.Columns.Add("Type", "Loại");

            // Buttons
            int btnWidth = 150, btnHeight = 40, spacing = 10;
            int startY = 540, startX = 20;

            this.btnAddEmployee.Location = new System.Drawing.Point(startX, startY);
            this.btnAddEmployee.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddEmployee.Text = "Thêm NV";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            this.btnEditEmployee.Location = new System.Drawing.Point(startX + (btnWidth + spacing), startY);
            this.btnEditEmployee.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnEditEmployee.Text = "Sửa NV";
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);

            this.btnDeleteEmployee.Location = new System.Drawing.Point(startX + 2 * (btnWidth + spacing), startY);
            this.btnDeleteEmployee.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDeleteEmployee.Text = "Xóa NV";
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);

            this.btnDeleteAll.Location = new System.Drawing.Point(startX + 3 * (btnWidth + spacing), startY);
            this.btnDeleteAll.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDeleteAll.Text = "Xóa tất cả";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);

            this.btnAttendance.Location = new System.Drawing.Point(startX + 4 * (btnWidth + spacing), startY);
            this.btnAttendance.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAttendance.Text = "Chấm công";
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);

            this.btnRandomAttendance.Location = new System.Drawing.Point(startX + 5 * (btnWidth + spacing), startY);
            this.btnRandomAttendance.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnRandomAttendance.Text = "Random chấm công";
            this.btnRandomAttendance.Click += new System.EventHandler(this.btnRandomAttendance_Click);

            this.btnPayroll.Location = new System.Drawing.Point(startX + 6 * (btnWidth + spacing), startY);
            this.btnPayroll.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnPayroll.Text = "Bảng lương";
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);

            this.btnGenerateSample.Location = new System.Drawing.Point(startX + 7 * (btnWidth + spacing), startY);
            this.btnGenerateSample.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnGenerateSample.Text = "Tạo 1000 NV";
            this.btnGenerateSample.Click += new System.EventHandler(this.btnGenerateSample_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnRandomAttendance);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.btnGenerateSample);
            this.Text = "Quản lý nhân sự";

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
