using System;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public class TaskAssignment
    {
        public string EmployeeID { get; set; } // Mã nhân viên
        public string TaskName { get; set; }   // Tên công việc
        public DateTime Date { get; set; }     // Ngày thực hiện
        public double Bonus { get; set; }      // Thưởng task

        public TaskAssignment()
        {
            EmployeeID = "";
            TaskName = "";
            Date = DateTime.Now;
            Bonus = 0;
        }

        public TaskAssignment(string employeeID, string taskName, DateTime date, double bonus)
        {
            EmployeeID = employeeID;
            TaskName = taskName;
            Date = date;
            Bonus = bonus;
        }
    }
}
