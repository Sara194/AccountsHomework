using System;
using System.Collections.Generic;

namespace AccountsHomework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Money money1 = new Money(1);
            Money money2 = new Money(4);
            Money money3 = new Money(17);
            Money money4 = new Money(152);
            Money money5 = new Money(555);
            Money money6 = new Money(666);
            AccountItem accountItem1 = new AccountItem("a", "b", "c", money1, new DateTime(2019, 03, 13), AccountItem.Category.Spending);
            AccountItem accountItem2 = new AccountItem("ds", "dsf", "kds", money2, new DateTime(2019, 02, 13), AccountItem.Category.Spending);
            AccountItem accountItem3 = new AccountItem("sg", "dsf", "kds", money3, new DateTime(2019, 02, 14), AccountItem.Category.Spending);
            AccountItem accountItem4 = new AccountItem("hjgsdfj", "hjsf", "dsj", money4, new DateTime(2019, 03, 13), AccountItem.Category.Income);
            AccountItem accountItem5 = new AccountItem("hhh", "dsf", "kds", money5, new DateTime(2019, 04, 13), AccountItem.Category.Income);
            AccountItem accountItem6 = new AccountItem("wzb", "dsf", "kds", money6, new DateTime(2019, 03, 13), AccountItem.Category.Income);
            List<AccountItem> accountLists = new List<AccountItem>();
            accountLists.Add(accountItem1);
            accountLists.Add(accountItem2);
            accountLists.Add(accountItem3);
            accountLists.Add(accountItem4);
            accountLists.Add(accountItem5);
            accountLists.Add(accountItem6);

            Accounts accounts = new Accounts(accountLists);

            foreach (AccountItem item in accounts.Display(new DateTime(2019, 02, 13)))
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(accounts.TotalRevenue(new DateTime(2019, 02, 13)).Value);

        }
    }
}
