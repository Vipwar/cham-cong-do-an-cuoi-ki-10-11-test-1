using System;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public class AttendanceRecord
    {
        public string EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public AttendanceRecord() { }

        public AttendanceRecord(string employeeID, DateTime date, bool isPresent, string name, string position)
        {
            EmployeeID = employeeID;
            Date = date;
            IsPresent = isPresent;
            Name = name;
            Position = position;
        }
    }
}
