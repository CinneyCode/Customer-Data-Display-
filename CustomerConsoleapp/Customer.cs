using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsoleapp
{
    class Customer
    {
        // PUBLIC DATA
        private int custNum;
        private string lastName;
        private string firstName;
        private string region;
        private string addr1;
        private string addr2;
        private string city;
        private string state;
        private string zip;

        // PUBLIC CONSTRUCTOR
        public Customer(int newNum, string newLast, string newFirst,
            string newRegion, string newAddr1, string newAddr2,
            string newCity, string newState, string newZip)
        {
            Cust_Num = newNum;
            Last_Name = newLast;
            First_Name = newFirst;
            Cust_Reg = newRegion;
            Cust_Addr1 = newAddr1;
            Cust_Addr2 = newAddr2;
            Cust_City = newCity;
            Cust_State = newState;
            Cust_Zip = newZip;
        }
        // PUBLIC PROPERTY
        public int Cust_Num
        {
            get { return custNum; }
            set
            {
                if (value > 0)
                    custNum = value;
                else
                    throw new Exception("Cust Err - bad cutomer number");
            }
        }
        public string Last_Name
        {
            get { return lastName; }
            set
            {
                if (value.Trim().Length > 0)
                    lastName = value;
                else
                    throw new Exception("Cust Err - bad cutomer Last Name");
            }
        }
        public string First_Name
        {
            get { return firstName; }
            set
            {
                if (value.Trim().Length > 0)
                    firstName = value;
                else
                    throw new Exception("Cust Err - bad cutomer Fist Name");
            }
        }
        public string Cust_Reg
        {
            get { return region; }
            set
            {
                if (value.Trim().Length > 0)
                    region = value;
                else
                    throw new Exception("Cust Err - bad Region");
            }
        }
        public string Cust_Addr1
        {
            get { return addr1; }
            set
            {
                if (value.Trim().Length > 0)
                    addr1 = value;
                else
                    throw new Exception("Cust Err - bad Address1");
            }
        }
        public string Cust_Addr2
        {
            get { return addr2; }
            set
            {
                    addr2 = value;
            }
        }
        public string Cust_City
        {
            get { return city; }
            set
            {
                if (value.Trim().Length > 0)
                    city = value;
                else
                    throw new Exception("Cust Err - bad city");
            }
        }
        public string Cust_State
        {
            get { return state; }
            set
            {
                if (value.Trim().Length == 2)
                    state = value;
                else
                    throw new Exception("Cust Err - bad staet");
            }
        }
        public string Cust_Zip
        {
            get { return zip; }
            set
            {
                if (value.Trim().Length == 5 || value.Trim().Length == 10)
                    zip = value;
                else
                    throw new Exception("Cust Err - bad zip");
            }
        }
        // PUBLIC METHOD
        public override string ToString()
        {
            string returnString = firstName + " " + lastName + "\n" + addr1 + "\n" + addr2 + "\n" + city + ", " + state + "  " + zip;

            return returnString;
        }



    }
}
