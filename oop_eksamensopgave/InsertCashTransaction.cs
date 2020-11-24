using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    class InsertCashTransaction : Transaction
    {
        public override string ToString()
        {
            return $"inserted {Amount} into {User.Username}'s account. Time: {Date}; Id: {Id}";
        }

        public override void Execute()
        {
            User.Balance += Amount;
        }

        public InsertCashTransaction(int id, User user, DateTime date, decimal amount) : base(id, user, date, amount) { }
    }
}
