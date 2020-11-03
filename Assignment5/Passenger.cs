using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    class ExceedBookingException :Exception
    {
        public ExceedBookingException(string me): base(me)
        {

        }
    }
    class Passenger
    {
        string Name;
        int Age;
        internal Passenger(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
                Console.WriteLine(" NAME:{0}||AGE:{1}", Name, Age);
        }

        public void TicketBooking(int no_of_tickets)
        {
            try
            {
                if (no_of_tickets>2)
                {
                    throw new ExceedBookingException("cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine(" Ticket Booked Successfully");
                }

            }
            catch( Exception e)
            {
                Console.WriteLine(" Message:{0}", e.Message);
            }
        }
    }
    class Test
    {
        static void Main()
        {
            Passenger passenger = new Passenger("Rahul", 36);
            passenger.TicketBooking(4);
            Console.Read();
        }
    }
}
