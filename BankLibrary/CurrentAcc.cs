using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public  class CurrentAcc : Bank
    {
		private double overDraftLimit;

		public double OverDraftLimit
		{
			get { return overDraftLimit; }
			set { overDraftLimit = value; }
		}

        public CurrentAcc()
        {
            
        }

        public CurrentAcc(string name, double limit) : base(name) 
        {
            OverDraftLimit = limit;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public override void Withdraw(double amount)
        {
            
        }

    }
}
