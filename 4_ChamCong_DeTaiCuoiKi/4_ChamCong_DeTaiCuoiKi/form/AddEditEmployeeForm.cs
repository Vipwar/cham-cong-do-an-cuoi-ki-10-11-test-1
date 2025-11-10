using _4_ChamCong_DeTaiCuoiKi.modal;
using System;
using System.Windows.Forms;

namespace _4_ChamCong_DeTaiCuoiKi.form
{
    public partial class AddEditEmployeeForm : Form
    {
        private Company company;
        private Employee editEmployee = null;

        public AddEditEmployeeForm(Company company)
        {
            InitializeComponent();
            this.company = company;

            comboType.Items.Add("Regular");
            comboType.Items.Add("Contract");
            comboType.Items.Add("Manager");
            comboType.SelectedIndex = 0;

            lblContractDuration.Visible = numContractDuration.Visible = false;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtID, "Nhập mã nhân viên, ví dụ: E001");
            toolTip.SetToolTip(txtName, "Nhập họ và tên nhân viên");
            toolTip.SetToolTip(txtPosition, "Nhập chức vụ, ví dụ: Staff, Developer, Manager");
            toolTip.SetToolTip(numBaseSalary, "Nhập lương cơ bản bằng số (VNĐ)");
            toolTip.SetToolTip(comboType, "Chọn loại nhân viên");
            toolTip.SetToolTip(numContractDuration, "Nhập số tháng hợp đồng (chỉ với Contract)");

            comboType.SelectedIndexChanged += ComboType_SelectedIndexChanged;
        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblContractDuration.Visible = numContractDuration.Visible = (comboType.SelectedItem.ToString() == "Contract");
        }

        public void LoadEmployee(Employee emp)
        {
            editEmployee = emp;
            txtID.Text = emp.EmployeeID;
            txtName.Text = emp.Name;
            txtPosition.Text = emp.Position;
            numBaseSalary.Value = (decimal)emp.BaseSalary;
            comboType.SelectedItem = emp.GetType().Name;

            if (emp is ContractEmployee)
            {
                lblContractDuration.Visible = numContractDuration.Visible = true;
                numContractDuration.Value = ((ContractEmployee)emp).ContractDurationMonths;
            }
            else
            {
                lblContractDuration.Visible = numContractDuration.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            double baseSalary = (double)numBaseSalary.Value;
            Employee emp;
            string type = comboType.SelectedItem.ToString();

            switch (type)
            {
                case "Regular":
                    emp = new RegularEmployee(txtID.Text.Trim(), txtName.Text.Trim(), txtPosition.Text.Trim(), baseSalary);
                    break;
                case "Contract":
                    emp = new ContractEmployee(txtID.Text.Trim(), txtName.Text.Trim(), txtPosition.Text.Trim(), baseSalary, (int)numContractDuration.Value);
                    break;
                case "Manager":
                    emp = new Manager(txtID.Text.Trim(), txtName.Text.Trim(), txtPosition.Text.Trim(), baseSalary, "Sales");
                    break;
                default:
                    MessageBox.Show("Loại nhân viên không hợp lệ!");
                    return;
            }

            if (editEmployee != null)
            {
                company.RemoveEmployee(editEmployee);
            }

            company.AddEmployee(emp);
            MessageBox.Show("Đã lưu nhân viên!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
