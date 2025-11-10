using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    public class Department
    {
        public string Id { get; set; }
        public string Name { get; set; }


        public Department() { }


        public Department(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
