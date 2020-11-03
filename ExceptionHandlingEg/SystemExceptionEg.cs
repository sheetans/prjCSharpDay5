using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEg
{
    class SystemExceptionEg
    {
        static void Main()
        {
            int num = 30;
            string[] Fruit = { "Orange", "Mango" };
            int[,] arr = { { 10, 20, 90 }, { 30, 40, 80 } };

            // num= num/0;
            try
            {
                Console.WriteLine("num:{2}", num);
                Console.WriteLine("Fruit[2]:{0}", Fruit[2]);
                num = num / 0;
                int add =10 + 30;
                Console.WriteLine("Addition:{0}", add);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Message:{0}", ex);
            }
            catch (IndexOutOfRangeException ex )
            {
                Console.WriteLine("Message:{0}", ex);
            }
            catch (Exception ex)
            {
               // Console.WriteLine("Message:{0}", ex);
                Console.WriteLine("Message:{0}", ex.Message);
                Console.WriteLine("Source:{0}", ex.Source);
                Console.WriteLine("Message:{0}", ex.StackTrace);
                Console.WriteLine("Message:Please Check the Inputs");

            }
            finally
            {
                Console.WriteLine("Used To Close Opened Connection");
            }
            num = num * num;
            Console.WriteLine("multiplication:{0}", num);
            Console.WriteLine("End of systemException");
            Console.Read();
        }

    }
}
