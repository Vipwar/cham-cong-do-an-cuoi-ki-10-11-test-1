using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ChamCong_DeTaiCuoiKi.modal
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string FullName { get; set; }


        protected Person() { }


        protected Person(string id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }
    }
}
