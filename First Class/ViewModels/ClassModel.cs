using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class.ViewModels
{
   public class ClassModel
    {
        public ClassGroup MainClasses { get; set; }
        public bool IsDataLoaded { get; set; }

        public ClassModel()
        {
            MainClasses = new ClassGroup();
        }

       public void LoadData(){
           //sample data
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 100", CourseCode = "TST 100" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 101", CourseCode = "TST 101" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 102", CourseCode = "TST 102" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 103", CourseCode = "TST 103" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 103", CourseCode = "TST 103" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 103", CourseCode = "TST 103" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 103", CourseCode = "TST 103" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 103", CourseCode = "TST 103" });
           MainClasses.Items.Add(new ClassData() { CourseName = "Testing 103", CourseCode = "TST 103" });
       }
    }
}
