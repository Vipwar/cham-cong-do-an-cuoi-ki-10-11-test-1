namespace _4_ChamCong_DeTaiCuoiKi.form
{
    partial class AddEditEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblBaseSalary;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblContractDuration;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.NumericUpDown numBaseSalary;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.NumericUpDown numContractDuration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblContractDuration = new System.Windows.Forms.Label();

            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.numBaseSalary = new System.Windows.Forms.NumericUpDown();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.numContractDuration = new System.Windows.Forms.NumericUpDown();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numBaseSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContractDuration)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.lblID.Text = "Mã NV";
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Tên NV";
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.lblPosition.Text = "Chức vụ";
            this.lblPosition.Location = new System.Drawing.Point(20, 100);
            this.lblBaseSalary.Text = "Lương cơ bản";
            this.lblBaseSalary.Location = new System.Drawing.Point(20, 140);
            this.lblType.Text = "Loại NV";
            this.lblType.Location = new System.Drawing.Point(20, 180);
            this.lblContractDuration.Text = "Số tháng hợp đồng";
            this.lblContractDuration.Location = new System.Drawing.Point(20, 220);

            // Controls
            this.txtID.Location = new System.Drawing.Point(200, 20);
            this.txtName.Location = new System.Drawing.Point(200, 60);
            this.txtPosition.Location = new System.Drawing.Point(200, 100);
            this.numBaseSalary.Location = new System.Drawing.Point(200, 140);
            this.numBaseSalary.Maximum = 100000000;
            this.comboType.Location = new System.Drawing.Point(200, 180);
            this.numContractDuration.Location = new System.Drawing.Point(200, 220);
            this.numContractDuration.Maximum = 60;

            // Buttons
            this.btnSave.Text = "Lưu";
            this.btnSave.Location = new System.Drawing.Point(50, 270);
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Hủy";
            this.btnCancel.Location = new System.Drawing.Point(200, 270);
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add controls
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblBaseSalary);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblContractDuration);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.numBaseSalary);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.numContractDuration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Text = "Thêm / Sửa nhân viên";

            ((System.ComponentModel.ISupportInitialize)(this.numBaseSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContractDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
