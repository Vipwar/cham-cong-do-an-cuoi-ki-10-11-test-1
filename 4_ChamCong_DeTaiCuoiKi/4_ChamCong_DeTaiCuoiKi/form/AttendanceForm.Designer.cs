namespace _4_ChamCong_DeTaiCuoiKi.form
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();

            // dgvAttendance
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top |
                                  System.Windows.Forms.AnchorStyles.Bottom) |
                                  System.Windows.Forms.AnchorStyles.Left) |
                                  System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.Location = new System.Drawing.Point(12, 12);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(960, 500);

            // btnSave
            this.btnSave.Text = "Lưu";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.Location = new System.Drawing.Point(12, 520);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.Location = new System.Drawing.Point(120, 520);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AttendanceForm
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AttendanceForm";
            this.Text = "Chấm công";

            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
