using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsHomework
{
    public class AccountItem
    {
        public String Name { get; set; }
        public String Content { get; set; }
        public String Note { get; set; }
        public Money Amount { get; set; }
        public DateTime OccuredTime { get; set; }
        public enum Category { Spending,Income};
        public Category category { get; set; }

        public AccountItem(String name, String content, String note, Money amount, DateTime occuredtime, Category category)
        {
            this.Name = name;
            this.Content = content;
            this.Note = note;
            this.Amount = amount;
            this.OccuredTime = occuredtime;
            this.category = category;
        }

        public override string ToString()
        {
            return $"name:{this.Name} , time:{this.OccuredTime.ToString()}, content:{this.Content}, note: {this.Note}";
        }

    }
}
