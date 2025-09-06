using ErrorHandling.Entities.Exceptions;

namespace ErrorHandling.Entities
{
	internal class Account
	{
		public int Number { get; set; }
		public string? Holder { get; set; }
		public double Balance { get; set; }
		public double WithdrawLimit { get; set; }

		public Account() { }

		public Account(int number, string? holder, double balance, double withdrawLimit)
		{
			Number = number;
			Holder = holder;
			Balance = balance;
			WithdrawLimit = withdrawLimit;
		}

		private void ValidateAmount(double amount)
		{
			if (amount <= 0)
				throw new DomainException("Amount should be greater than 0");
		}

		public void Deposit(double amount)
		{
			ValidateAmount(amount);

			Balance = amount;
		}

		public void Withdraw(double amount)
		{
			ValidateAmount(amount);

			if(amount > WithdrawLimit)
				throw new DomainException("Withdraw Error: The amount exceeds withdraw limit");

			if(amount > Balance)
				throw new DomainException("Withdraw Error: Not enough balance");

			Balance -= amount;
			Console.WriteLine("New Balance: " + Balance);
		}
	}
}
