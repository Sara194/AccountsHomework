using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsHomework
{
    public class Money
    {
        public double Value { get; set; }
        public Money(double value)
        {
            this.Value = value;

        }
        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.Value + money2.Value);


        }

        public static Money operator -(Money money1, Money money2)
        {
            return new Money(money1.Value - money2.Value);


        }
    }
}
