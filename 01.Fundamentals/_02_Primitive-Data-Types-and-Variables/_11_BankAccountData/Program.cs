using System;
using System.Collections.Generic;
namespace _11_BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Eva";
            var midleName = "Velcheva";
            var lastName = "Ivanova";
            var balanceInDollars = 200;
            var currency = "$";
            var bankName = "HSBC";
            var IBAN = "BG00001SF2030JS30";
            var creditCard_1 = "SomeCardID_1";
            var creditCard_2 = "SomeCardID_2";
            var creditCard_3 = "SomeCardID_3";
            
            var list_users_BankAccountData = new List<string>();
            list_users_BankAccountData.Add(firstName);
            list_users_BankAccountData.Add(midleName);
            list_users_BankAccountData.Add(lastName);
            list_users_BankAccountData.Add(balanceInDollars.ToString());
            list_users_BankAccountData.Add(currency);
            list_users_BankAccountData.Add(bankName);
            list_users_BankAccountData.Add(IBAN);
            list_users_BankAccountData.Add(creditCard_1);
            list_users_BankAccountData.Add(creditCard_2);
            list_users_BankAccountData.Add(creditCard_3);
            foreach (var data in list_users_BankAccountData)
            {
               Console.WriteLine($"User data: {data}");
            }
        }
    }
}