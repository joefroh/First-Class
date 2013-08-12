using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class.ViewModels
{
    public class TimeSlot
    {
        public Days Day { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public enum Days
        { Sun, Mon, Tue, Wed, Thu, Fri, Sat }
    }

    
}
