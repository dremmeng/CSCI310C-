using System;
using System.Collections.Generic;
using System.IO;

namespace Project3
{
    class Project3
    {
        static void Main()

        {
            try
            {
                string[] lines = File.ReadAllLines("customers.txt");
                List<Customer> customers = new List<Customer>();
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    customers.Add(new Customer(fields[0], fields[1], fields[2], fields[3], fields[4]));
                }
                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer.ToString());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
    public interface ICustomer
    {
        string GetName();
        string GetID();
    }
    public class Customer : ICustomer
    {
        private string lastName;
        private string firstName;
        private string customerID;
        private string businessName;
        private string phoneNumber;
        public Customer(string lastName, string firstName, string customerID, string businessName, string phoneNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.customerID = customerID;
            this.businessName = businessName;
            this.phoneNumber = phoneNumber;
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public override string ToString()
        {
            return String.Format(lastName + ", " + firstName + ", " + customerID + ", " + businessName + ", " + phoneNumber);
        }
        public string GetName()
        {
            return String.Format(firstName + lastName);
        }
        public string GetID()
        {
            return customerID;
        }
    }
}