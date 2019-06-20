using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsHomework
{
    public class Accounts
    {

        List<AccountItem> accountLists;

        public Accounts(List<AccountItem> accountLists)
        {
            this.accountLists = accountLists;
        }

        public Money TotalExpenditure(DateTime dateTime)
        {

            Money expenditure = new Money(0);

            foreach (AccountItem accountItem in accountLists)
            {
                if (accountItem.category == AccountItem.Category.Spending)
                {
                    if (dateTime.Month == accountItem.OccuredTime.Month)
                    {
                        expenditure = expenditure + accountItem.Amount;
                    }
                }
            }

            return expenditure;
        }

        public Money TotalIncome(DateTime dateTime)
        {

            Money totalIncome = new Money(0);

            foreach (AccountItem accountItem in accountLists)
            {
                if (accountItem.category == AccountItem.Category.Income)
                {
                    if (dateTime.Month == accountItem.OccuredTime.Month)
                    {
                        totalIncome = totalIncome + accountItem.Amount;
                    }
                }
            }

            return totalIncome;
        }

        public Money TotalRevenue(DateTime dateTime)
        {
            Money totalRevenue = this.TotalIncome(dateTime) - this.TotalExpenditure(dateTime);
            return totalRevenue;
        }

        public IEnumerable<AccountItem> Display(DateTime dateTime)
        {
            foreach (AccountItem accountItem in accountLists)
            {
                if (dateTime.Month == accountItem.OccuredTime.Month)
                {
                    yield return(accountItem);
                   
                }
            }
        }

    }
}
