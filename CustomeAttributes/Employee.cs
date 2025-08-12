using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     public class Employee
    {
     
      [MyCustomAttribute(true, true, true)]
        public int emp_id { get; set; }

        public string name { get; set; }

        public string designation { get; set; }

        public string address { get; set; }
      
}

