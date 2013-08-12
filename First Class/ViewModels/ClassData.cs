using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class.ViewModels
{
   public class ClassData
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public List<TimeSlot> TimeSlots { get; set; }

        public ClassData()
        {
            TimeSlots = new List<TimeSlot>();
        }
    }
}
