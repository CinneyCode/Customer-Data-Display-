using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // ADD for talking to access databases

namespace CustomerConsoleapp
{
    class CustomerDatabase
    {
        string cnxnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            " Data Source=Customers.accdb; Persist Security Info=false";

        string customerQuery = "Select * FROM CustomerTable";

        OleDbConnection custConnection;
        List<Customer> custList = new List<Customer>(); // To store data in a list
        //
        public List<Customer> ReadCustomerData()
        {
            // CREATE A CONNECTION TO THE DATABASE
            custConnection = new OleDbConnection(cnxnStr); // storing cust data into the list
            // OPEN THE CONNECTION TO THE DATABASE
            custConnection.Open();
            // CREATE A COMMAND TO EXECUTE WITH THE CONNECTION
            OleDbCommand custCmd = new OleDbCommand(customerQuery, custConnection);
            // EXECUTE READING OF DATA
            OleDbDataReader custReader = custCmd.ExecuteReader();
            while (custReader.Read())
            {
                // you have to much the Column Name exactly same as database Access Column
                Customer c = new Customer(
                    Convert.ToInt32(custReader["CustNum"]), Convert.ToString(custReader["LastName"]),
                    Convert.ToString(custReader["FirstName"]), Convert.ToString(custReader["Region"]),
                    Convert.ToString(custReader["Addr1"]), Convert.ToString(custReader["Addr2"]),
                    Convert.ToString(custReader["City"]), Convert.ToString(custReader["State"]),
                    Convert.ToString(custReader["Zip"]));
                custList.Add(c);
            }
            return custList;
        }
    }
}
