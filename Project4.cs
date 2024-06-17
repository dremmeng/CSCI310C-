using System;
using System.Collections.Generic;
using System.Linq;

namespace Project4
{
    public interface ICustomer
    {
        string name { get; set; }
    }
    public class Order
    {
        public event EventHandler<OrderEventArgs> OrderPlaced;
        public event EventHandler OrderReadyToShip;

        public void PlaceOrder(ICustomer customer)
        {
            Console.WriteLine($"Order placed for {customer.name}");
            AOrderPlaced(customer);
        }

        protected virtual void AOrderPlaced(ICustomer customer)
        {
            OrderPlaced?.Invoke(this, new OrderEventArgs { Customer = customer });
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order is ready to ship.");
            AOrderReadyToShip();
        }

        protected virtual void AOrderReadyToShip()
        {
            OrderReadyToShip?.Invoke(this, EventArgs.Empty);
        }
    }
    public class OrderEventArgs : EventArgs
    {
        public ICustomer Customer { get; set; }
    }
    public class Customer : ICustomer
    {
        public string name { get; set; }
    }

    public class OrderSubscriber
    {
        public void OrderPlaced(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Order placed for " + e.Customer.name + ".");
        }

        public void OrderReadyToShip(object sender, EventArgs e)
        {
            Console.WriteLine("Order is ready to ship.");
        }
    }

    class Project4
    {
        static void Main()
        {
            List<Customer> c = new List<Customer>();
            OrderSubscriber s = new OrderSubscriber();
            Order o = new Order();
            o.OrderPlaced += s.OrderPlaced;
            o.OrderReadyToShip += s.OrderReadyToShip;
            for (int i = 1; i <= 100; i++)
            {
                c.Add(new Customer { name = $"Customer " +i});
            }
            foreach (var customer in c)
            {
                o.PlaceOrder(customer);
            }
            o.ShipOrder();
            var selectedCustomers =c.Where(c => c.name.Contains("0")).ToList();
            Console.WriteLine("Selected Customers:");
            foreach (var selectedCustomer in selectedCustomers)
            {
                Console.WriteLine(selectedCustomer.name);
            }
        }
    }
}
