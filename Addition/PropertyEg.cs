using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class DellLaptop
    {    
       // Properties:to access the private variable of the class
        //read-only property

       public string Laptopname { get; private set; }  //get: Fetch the data and set: setting the data
        public string ram { get; set; }
        internal DellLaptop (string Laptopname,string ram)
        {
            this.Laptopname = Laptopname;
            this.ram = ram;
        }
    }
    class Student
    {
        static void Main()
        {
            DellLaptop d = new DellLaptop("Inspiron13", "8gb");
            // d.Laptopname= "xxxx";//read only information
            Console.WriteLine("name:{0}", d.Laptopname);
            d.ram = "16gb";
            Console.WriteLine("ram:{0}", d.ram);
            Console.Read();
        }
    }
    class PropertyEg
    {
    }
}
