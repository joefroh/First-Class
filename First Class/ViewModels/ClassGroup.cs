using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class.ViewModels
{
    public class ClassGroup
    {
        public List<ClassData> Items { get; set; }

        public ClassGroup()
        {
            Items = new List<ClassData>();
        }
    }
}
