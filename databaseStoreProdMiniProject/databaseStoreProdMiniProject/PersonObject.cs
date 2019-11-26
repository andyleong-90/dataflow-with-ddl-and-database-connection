using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseStoreProdMiniProject
{
    public class PersonObject
    {
        private string name;
        private string nric;
        private string address;
        private string email;
        private DateTime dOB;
        private int phoneNo;

        public string Name { get => name; set => name = value; }
        public string Nric { get => nric; set => nric = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }
        public int PhoneNo { get => phoneNo; set => phoneNo = value; }

        public override string ToString()
        {
            return name + ", " + nric + ", " + Address + ", " + Email + ", " + DOB + ", " + PhoneNo;
        }
    }
}
