//*Program Name: Bank account 
//Programmer: Sufilka Kelton
 // Date: 12 / 19 / 2022
 //Description: Program keeps track of funds and shows your money 
 




using Classes;
using System.Globalization;

var account = new BankAccount("<Soup>", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());



