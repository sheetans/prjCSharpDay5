using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{ //generic has data type parameter is 'T'
    class Sample <T>
    {
        T oil;
        //int pid;
        internal Sample(T oil )
        {
            this.oil = oil;
        }
        
        // Normal Method
       /* void Swap(int n1,int n2)
        {
            int t;
            t = n1;
            n1 = n2;
            n2 = t;
        } */

            // Generic Method
        internal  void Swap<T>(T n1, T n2)
        {
            T t;
            t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("n1:{0}||n2:{1}", n1, n2);
        }
    }
    class GenericMethod_ClassEgcs
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("10liter");
            Sample<int> s1 = new Sample<int>(10);
            sample.Swap<int>(5, 6);
            sample.Swap<string>("You", "Me");

          /* Sample<int>.Swap<int>(5, 6);                  // Another way by Class
            Sample<string>.Swap<string>("You", "Me"); */
            Console.Read();
        }
    }
}
