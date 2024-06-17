using System;
using System.Collections.Generic;
using System.Linq;

namespace Project4
{
    public interface ICustomer
    {
        string Name { get; set; }
    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> OrderPlaced;
        public event EventHandler OrderReadyToShip;

        public void PlaceOrder(ICustomer customer)
        {
            Console.WriteLine($"Order placed for {customer.Name}");
            OnOrderPlaced(customer);
        }

        protected virtual void OnOrderPlaced(ICustomer customer)
        {
            OrderPlaced?.Invoke(this, new OrderEventArgs { Customer = customer });
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order is ready to ship.");
            OnOrderReadyToShip();
        }

        protected virtual void OnOrderReadyToShip()
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
        public string Name { get; set; }
    }

    public class OrderSubscriber
    {
        public void OrderPlacedHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Order placed for " + e.Customer.Name + ".");
        }

        public void OrderReadyToShipHandler(object sender, EventArgs e)
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
            Order order = new Order();
            order.OrderPlaced += s.OrderPlacedHandler;
            order.OrderReadyToShip += s.OrderReadyToShipHandler;
            for (int i = 1; i <= 100; i++)
            {
                c.Add(new Customer { Name = $"Customer " +i});
            }
            foreach (var customer in c)
            {
                order.PlaceOrder(customer);
            }
            order.ShipOrder();
            var selectedCustomers =c.Where(c => c.Name.Contains("5")).ToList();
            Console.WriteLine("Selected Customers:");
            foreach (var selectedCustomer in selectedCustomers)
            {
                Console.WriteLine(selectedCustomer.Name);
            }
        }
    }
}
