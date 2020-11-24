using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    class Stregsystem : IStregsystem
    {
        DateTime CurrentDate = DateTime.Now;
        static int TransactionId = 0;

        BuyTransaction BuyProduct(User user, Product product)
        {
            TransactionId++;
            return new BuyTransaction(TransactionId, user, CurrentDate, product.Price, product);
        }

        InsertCashTransaction AddCreditsToAccount(User user, Decimal amount)
        {
            TransactionId++;
            user.Balance += amount;
            return new InsertCashTransaction(TransactionId, user, CurrentDate, amount);
        }

        public void ExecuteTransaction(Transaction transaction)
        {

        }
    }
}
