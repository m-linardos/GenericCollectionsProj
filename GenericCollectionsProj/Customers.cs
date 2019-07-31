using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsProj {
    class Customers {

        List<Customer> customerList = new List<Customer>();

        public void LoadCustomers() {
            var cust1 = new Customer { Name = "P&G", State = "OH" };      // way to initialize the properties of class without having to create constructors for each customer
            var cust2 = new Customer { Name = "Microsoft", State = "WA" };
            var cust3 = new Customer { Name = "Target", State = "MN" };

            customerList.Add(cust1);        // Adding to our collection
            customerList.Add(cust2);
            customerList.Add(cust3);
        }

        public void PrintCustomers() {
            foreach (var cust in customerList) {// last perimeter is always collection and already exists; the other 3 sections in parens are created on the fly; can't use 'customer' because it's an instance of a class
                Console.WriteLine($"Customer name is {cust.name} and home state is {cust.State} ;

        }

    }

    public class Customer {         // add singular 'Customer' class after closing curly brace of Customers
        public string Name { get; set; }
        public string State { get; set; }
    }
}
