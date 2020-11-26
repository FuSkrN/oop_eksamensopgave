using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace oop_eksamensopgave
{
    delegate void UserBalanceNotification(User user, decimal balance);
    public class User : IComparable<User>
    {
        int _Id;
        public int Id
        {
            get { return _Id; }
            set
            {
                if (value > 0)
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
        }
        string _Firstname;
        public string Firstname
        {
            get { return _Firstname; }
            set
            {
                try
                {
                    _Firstname = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        string _Lastname;
        public string Lastname
        {
            get { return _Lastname; }
            set
            {
                try
                {
                    _Lastname = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        string _Username;
        public string Username
        {
            get { return _Username; }
            set
            {
                try
                {
                    _Username = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                try
                {
                    validateEmail(value);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        decimal _Balance;
        public decimal Balance
        {
            get { return _Balance; }
            set
            {
                try
                {
                    _Balance = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private List<Transaction> transactions = new List<Transaction>();
        internal List<Transaction> Transactions { get => transactions; set => transactions = value; }

        void validateEmail(string input)
        {
            Regex rxEmailLocal = new Regex(@"[^a-zA-Z0-9._,-]");
            Regex rxEmailDomain = new Regex(@"^[^a-zA-Z0-9]|[^a-zA-Z0-9.-]|[^a-zA-Z0-9]$");

            string[] splitStrings = input.Split("@"); //Splits Email around the @, neither string keeps the @

            if (splitStrings.Length == 2)
            {
                if (!rxEmailLocal.IsMatch(splitStrings[0]) && !rxEmailDomain.IsMatch(splitStrings[1]))
                    _Email = input;
                else
                    throw new ArgumentException("Email invalid");
            }
            else
                throw new ArgumentException("Email missing \"@");
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} ({Email})";
        }

        public int CompareTo(User other)
        {
            return Id.CompareTo(other.Id);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                User u = (User)obj;
                return (Id == u.Id) && (Firstname == u.Firstname) && (Lastname == u.Lastname) && (Username == u.Username) && (Email == u.Email);
            }
        }

        //maybe look at this. Dunno if it is a good idea to use id as a hash code
        public override int GetHashCode()
        {
            return Id;
        }

        public User(int id, string firstname, string lastname, string email, decimal balance)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Balance = balance;
        }
    }
}