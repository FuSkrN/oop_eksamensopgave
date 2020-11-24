using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    class BuyTransaction : Transaction
    {
        Product _Product;
        public Product Product
        {
            get { return _Product; }
            set
            {
                try
                {
                    _Product = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public override string ToString()
        {
            return $"{Product} purchased by {User} for {Amount} on {Date}";
        }

        public override void Execute()
        {
            if (User.Balance - Product.Price < 0)
            {
                throw new InsufficientFundsException(User, Product);
            }
            else if (Product.Active == false)
            {
                throw new ProductNotAvailableException("product is not available");
            }
            else
            {
                User.Balance -= Product.Price;
            }
        }

        public BuyTransaction(int id, User user, DateTime date, decimal amount, Product product) : base(id, user, date, amount)
        {
            this.Product = product;
        }
    }
}
