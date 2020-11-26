using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    interface IStregsystem
    {
        IEnumerable<Product> ActiveProducts { get; } //check
        InsertCashTransaction AddCreditsToAccount(User user, int amount); //check
        BuyTransaction BuyProduct(User user, Product product); //check
        Product GetProductByID(int id); //check
        IEnumerable<Transaction> GetTransactions(User user, int count); //think its check
        User GetUsers(Func<User, bool> predicate);
        User GetUserByUsername(string username); //check
        event UserBalanceNotification UserBalanceWarning;
    }
}
