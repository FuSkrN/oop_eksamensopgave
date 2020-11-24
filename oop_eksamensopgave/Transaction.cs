using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    class Transaction
    {
        int _Id;
        public int Id
        {
            get { return _Id; }
            set
            {
                try
                {
                    _Id = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        User _User;
        public User User
        {
            get { return _User; }
            set
            {
                try
                {
                    _User = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                try
                {
                    _Date = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                try
                {
                    _Amount = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public override string ToString()
        {
            return $"{Id} {User} {Amount} {Date}";
        }

        public virtual void Execute() { }

        public Transaction(int id, User user, DateTime date, decimal amount)
        {
            this.Id = id;
            this.User = user;
            this.Date = date;
            this.Amount = amount;
        }
    }
}
