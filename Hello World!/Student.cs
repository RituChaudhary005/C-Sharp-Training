using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{ 

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Marks { get; set; }

        public string GetResult()
        {
            return Marks >= 40 ? "Pass" : "Fail";
        }
    }
}

