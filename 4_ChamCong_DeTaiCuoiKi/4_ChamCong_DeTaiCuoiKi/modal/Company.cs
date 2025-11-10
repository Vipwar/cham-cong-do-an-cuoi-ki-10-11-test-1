using System;
using System.Collections.Generic;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    [Serializable]
    public class Company
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
        public List<TaskAssignment> TaskAssignments { get; set; } = new List<TaskAssignment>();

        public void AddEmployee(Employee emp)
        {
            if (emp != null && !Employees.Exists(e => e.EmployeeID == emp.EmployeeID))
                Employees.Add(emp);
        }

        public void RemoveEmployee(Employee emp)
        {
            if (emp != null)
                Employees.Remove(emp);
        }

        public void AddAttendanceRecord(AttendanceRecord record)
        {
            if (record != null)
            {
                var existing = AttendanceRecords.Find(a => a.EmployeeID == record.EmployeeID && a.Date == record.Date);
                if (existing != null)
                    AttendanceRecords.Remove(existing);

                AttendanceRecords.Add(record);
            }
        }

        public void AddTaskAssignment(TaskAssignment task)
        {
            if (task != null)
                TaskAssignments.Add(task);
        }

        public void GenerateSampleEmployees(int count)
        {
            Random rnd = new Random();
            string[] firstNames = { "Nguyen", "Tran", "Le", "Pham", "Hoang", "Vu" };
            string[] lastNames = { "An", "Binh", "Cuong", "Dung", "Hoa", "Khanh", "Linh", "Minh", "Phuc" };
            string[] positions = { "Staff", "Developer", "Designer", "Tester", "Support" };
            string[] departments = { "Sales", "Marketing", "IT", "HR", "Finance" };

            for (int i = 1; i <= count; i++)
            {
                string empID = "E" + i.ToString("D4");
                string name = firstNames[rnd.Next(firstNames.Length)] + " " + lastNames[rnd.Next(lastNames.Length)];
                string position = positions[rnd.Next(positions.Length)];
                double baseSalary = rnd.Next(5000000, 20000000); // 5-20 triệu
                int type = rnd.Next(3); // 0: Regular, 1: Contract, 2: Manager

                Employee emp = null;
                if (type == 0)
                    emp = new RegularEmployee(empID, name, position, baseSalary);
                else if (type == 1)
                    emp = new ContractEmployee(empID, name, position, baseSalary, rnd.Next(1, 24));
                else
                    emp = new Manager(empID, name, position, baseSalary, departments[rnd.Next(departments.Length)]);

                AddEmployee(emp);
            }
        }

        public void GenerateRandomAttendance(int month, int year)
        {
            Random rnd = new Random();
            foreach (Employee emp in Employees)
            {
                bool isPresent = rnd.Next(0, 2) == 1;
                AttendanceRecord record = new AttendanceRecord(emp.EmployeeID, new DateTime(year, month, 1), isPresent, emp.Name, emp.Position);
                AddAttendanceRecord(record);
            }
        }

        public int GetAttendanceCount(string empID, int month, int year)
        {
            int count = 0;
            foreach (var record in AttendanceRecords)
            {
                if (record.EmployeeID == empID && record.Date.Month == month && record.Date.Year == year && record.IsPresent)
                    count++;
            }
            return count;
        }

        public List<AttendanceRecord> GetAttendanceByEmployee(string empID, int month, int year)
        {
            List<AttendanceRecord> list = new List<AttendanceRecord>();
            foreach (var record in AttendanceRecords)
            {
                if (record.EmployeeID == empID && record.Date.Month == month && record.Date.Year == year)
                    list.Add(record);
            }
            return list;
        }

        public int GetTaskCount(string empID, int month, int year)
        {
            int count = 0;
            foreach (var task in TaskAssignments)
            {
                if (task.EmployeeID == empID && task.Date.Month == month && task.Date.Year == year)
                    count++;
            }
            return count;
        }

        public List<TaskAssignment> GetTasksByEmployee(string empID, int month, int year)
        {
            List<TaskAssignment> list = new List<TaskAssignment>();
            foreach (var task in TaskAssignments)
            {
                if (task.EmployeeID == empID && task.Date.Month == month && task.Date.Year == year)
                    list.Add(task);
            }
            return list;
        }
    }
}
