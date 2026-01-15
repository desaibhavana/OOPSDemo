namespace BankLibrary
{
    public abstract    class Bank
    {     

        #region Properties
        private string accHolderName;

        public string AccountHolderName
        {
            get { return accHolderName; }
            set { accHolderName = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        private int accountNo;

        public int AccountNo
        {
            get { return accountNo; }
          private  set { accountNo = value; }
        }

        private static int count;

        #endregion


        #region Methods

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Virtual method can be overridden by derived class
        //public virtual void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}


        public abstract void Withdraw(double amount);


        public override string ToString()
        {
            return $"AccountNo : {AccountNo},    AccountHolderName : {AccountHolderName}, Balance : {Balance}";
        }
        #endregion
        #region Constructors
        public Bank()
        {
            count++;
            this.AccountNo = count;
        }
        public Bank(string name) : this()
        {
            AccountHolderName = name;
        }
        static Bank()
        {
            count = 100;
        }
        #endregion
    }
}
