using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    public class Product
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
        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                try
                {
                    _Name = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        decimal _Price;
        public decimal Price
        {
            get { return _Price; }
            set
            {
                try
                {
                    _Price = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        bool _Active;
        public bool Active
        {
            get { return _Active; }
            set
            {
                try
                {
                    _Active = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        bool _CanBeBoughtOnCredit;
        public bool CanBeBoughtOnCredit
        {
            get { return _CanBeBoughtOnCredit; }
            set
            {
                try
                {
                    _CanBeBoughtOnCredit = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }

        public Product(int id, string name, decimal price, bool active, bool canbeboughtoncredit)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Active = active;
            this.CanBeBoughtOnCredit = canbeboughtoncredit;
        }
    }
}
