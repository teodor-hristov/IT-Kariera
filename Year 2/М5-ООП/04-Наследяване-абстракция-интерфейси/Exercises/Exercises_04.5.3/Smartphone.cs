using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises_04._5._3
{
    class Smartphone : IConnectable, ICallable
    {
        private string phoneNumber;
        private string url;

        public string Url
        {
            get { return url; }
            set
            {
                if (!Regex.IsMatch(value, @"[0-9]"))
                {
                    url = value;
                }
                else
                {
                    Console.WriteLine("Invalid url!");
                    this.url = null;
                }
            }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z]"))
                {
                    phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid phone number!");
                    this.phoneNumber = null;
                }
            }
        }


        public void Browse()
        {
            Console.WriteLine($"Browsing... {this.Url}");
        }

        public void Call()
        {
            Console.WriteLine($"Calling... {this.PhoneNumber}");
        }
    }
}
