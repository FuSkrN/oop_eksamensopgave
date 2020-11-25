using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    class Stregsystem : IStregsystem
    {
        DateTime CurrentDate = DateTime.Now;
        static int TransactionId = 0;
        List<Product> products = new List<Product>();
        List<User> users = new List<User>();

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

        User GetUserByUsername(string username)
        {
            foreach (User u in users)
            {
                if (u.Username == username)
                {
                    return u;
                }
            }

            return null;
        }

        Product GetProductByID(int id)
        {
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            //probs really bad. dunno what to do
            return null;
        }

        

        event UserBalanceNotification UserBalanceWarning;
    }
}
