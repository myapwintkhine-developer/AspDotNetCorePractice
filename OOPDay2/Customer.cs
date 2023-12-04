using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    public class Customer
    {
        public string Name { get; set; }
        private string nrc;

        public string NRC
        {
            get { return nrc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Invalid nrc"); nrc = value;
            }
        }

        private string phoneNo;

        public string PhoneNo
        {
            get { return phoneNo; }
            set
            {
                if (value.Length < 0 || value.Length > 11)
                    throw new ArgumentOutOfRangeException("Invalid phone no");
                phoneNo = value;
            }
        }

        public string Address { get; set; }
        public BankAccount BankAccount { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Customer Info:");
            Console.WriteLine($"Name: {Name}; NRC: {NRC}; PhoneNo: {PhoneNo};Address:{Address}");
        }
    }
}
