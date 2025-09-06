using ErrorHandling.Entities;
using ErrorHandling.Entities.Exceptions;

try
{
	Console.WriteLine("Enter account data");

	Console.Write("Number: ");
	var number = int.Parse(Console.ReadLine() ?? "0");

	Console.Write("Holder: ");
	var holder = Console.ReadLine() ?? "guest";

	Console.Write("Initial balance: ");
	var initialBalance = double.Parse(Console.ReadLine() ?? "0.0");

	Console.Write("Withdraw limit: ");
	var withdrawList = double.Parse(Console.ReadLine() ?? "0");
	Console.WriteLine();

	var account = new Account(number, holder, initialBalance, withdrawList);


	Console.Write("Enter amount for withdraw: ");
	var amount = double.Parse(Console.ReadLine() ?? "0");

	account.Withdraw(amount);
}
catch (DomainException e)
{
	Console.WriteLine(e.Message);
}
catch(Exception e)
{
	Console.WriteLine(e.Message);
}
