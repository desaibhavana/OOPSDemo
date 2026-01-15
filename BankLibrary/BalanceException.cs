using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public    class BalanceException : Exception
    {
        public BalanceException(string msg) : base(msg) 
        {
            
        }
    }
}
