using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg2
{
    class InterviewRound1
    {
        internal virtual void Result()
        {
            Console.WriteLine("Round1:Cleared:7/10");
        }
        public int Score()
        {
            return 7;
        }
    }
    class InterviewRound2: InterviewRound1
    {
        internal override void Result()
        {
            base.Result();//Round1
            Console.WriteLine("Round2:Cleared:8/10");
        }
        public new int Score()
        {
            return 8;
        }
    }
    class InterviewRound3 : InterviewRound2
    {
        internal override void Result()
        {
            base.Result();//Round2
            Console.WriteLine("Round3:NotCleared:4/10");
        }
    }

    class VirtualEg
    {
        static void Main()
        {

            InterviewRound1 r1 = new InterviewRound1();
            // r1.Result();
            r1.Score();
            InterviewRound2 r2 = new InterviewRound2();
            // r2.Result(); 
            r2.Score();
            InterviewRound3 r3 = new InterviewRound3();
            r3.Result();
            Console.Read();
        }
    }
}
