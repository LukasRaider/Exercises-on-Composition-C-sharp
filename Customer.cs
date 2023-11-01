using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer {
        private int id;
        private string name;
        private int discount;

        public Customer(int id, String name, int discount) { this.id = id; this.name = name; this.discount = discount; }
        public int getId() { return id; }
        public string getName() { return name; }
        public int getDiscount() { return discount; }
        public void setDiscount(int discount) { this.discount = discount; }
        public String toString() { return $"name {id}, {discount}%"; }
    }
    class Invoice {
        private int id;
        private Customer customer;
        private double amount;
        public Invoice(int id, Customer customer, double amount) { this.id = id; this.customer = customer; this.amount = amount; }
        public int getId() { return id; }
        public Customer getCustomer() { return customer; }
        public void setCustomer(Customer customer) { this.customer = customer; }
        public double getAmount() { return amount; }
        public void setAmount(double amount) { this.amount = amount; }
        public int getCustomerId() { return customer.getId(); }
        public String getCustomerName() { return customer.getName(); }
        public int getCustomerDiscount() { return customer.getDiscount(); }
        public double getAmountAfterDiscount() { double newamount;newamount = amount * (customer.getDiscount() / 100); return  (amount - newamount); }
        public String toString() { return $"Invoice {customer.getId()}, {customer.getDiscount()}%, ammount {getAmount()}, after discount {getAmountAfterDiscount()}"; }

    }
    class TestCustomer {
        public static void Mainx(string[] args)
        {
            Customer c1 = new Customer(5,"Jan",10);
            Invoice i1 = new Invoice(5,c1,15000);
            Invoice i2 = new Invoice(6,new Customer(6,"Jana",20),40000);
            Console.WriteLine($"Customer 1 {c1.getName()} is {c1.getId()} and have {c1.getDiscount()}% discount");
            Console.WriteLine($"Customer 1 {c1.toString()}");
            Console.WriteLine($"Invoice 1 {i1.toString()}");
        }
    }


}
