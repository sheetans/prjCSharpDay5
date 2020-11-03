using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class InSufficientBalanceException:Exception
    {
        public InSufficientBalanceException(string me):base(me)
        {

        }
    }
    class LoanProcess
    {
        int Loan_No,  Account_Balance;
        double EMI_Amount, LoanAmount;
        string CustomerName;
        string ERR;

        internal void calculate_EMI()
        {
            EMI_Amount = ((LoanAmount * (.13 * 3))  + LoanAmount)/(12*3);
            Console.WriteLine("EMI Amount:{0}", EMI_Amount);

        }

        internal LoanProcess(int Loan_No, double LoanAmount, int Account_Balance, string CustomerName)
        {
            this.Loan_No = Loan_No;
            this.LoanAmount = LoanAmount;
            this.Account_Balance = Account_Balance;
            this.CustomerName = CustomerName;
            calculate_EMI();
        }
        public void CheckBalance()
        {
            try
            {
                if (Account_Balance < EMI_Amount)
                {
                    throw new InSufficientBalanceException(" Not Sufficient Balance to Repay Loan");
                }
                else
                {
                    Console.WriteLine(" Successfully EMI paid");
                }
            }
            catch( Exception e)
            {
                ERR = e.Message;
                Console.WriteLine("Message:{0}", e.Message);
            }
            finally
            {
                if (ERR != null)

                {
                    Console.WriteLine("Not Sufficient Balance to Repay Loan");
                }
                else
                {
                    Console.WriteLine(" Thank you for paying EMI");
                }
            }
            
        }
        static void Main()
        {
            LoanProcess loanProcess = new LoanProcess(101,100000,2000,"Aman");
            loanProcess.CheckBalance();
           
            Console.Read();
            
        }

    }
}
