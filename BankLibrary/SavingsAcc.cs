using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class SavingsAcc : Bank
    {
		private bool isSalAcc;

		public bool IsSalaryAccount
		{
			get { return isSalAcc; }
			set { isSalAcc = value; }
		}

        public SavingsAcc()
        {
                
        }

        public SavingsAcc(string name, bool isSalaryAcc) : base(name) 
        {         
            IsSalaryAccount = isSalaryAcc;
        }

        
        public sealed  override string ToString()
        {
            return base.ToString() + $"  IsSalaryAccount : {IsSalaryAccount}";
        }

        public override void Withdraw(double amount)
        {
            //if SalaryAcc true withdraw upto 0 balance
            //if SalaryAcc false minimum balance 1000

            if (IsSalaryAccount ==true)
            {
                if ((Balance - amount)>=0)
                {
                    Balance -= amount;
                }
                else
                {
                    throw new BalanceException("Balance not enough"); 
                }
            }

            if (IsSalaryAccount == false)
            {
                if ((Balance - amount) >= 1000)
                {
                    Balance -= amount;
                }
                else
                {
                    throw new BalanceException("Balance not enough");
                }
            }
        }
    }
}
