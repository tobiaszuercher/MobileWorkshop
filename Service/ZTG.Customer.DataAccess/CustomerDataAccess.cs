using System.Collections.Generic;
using System.Linq;
using ZTG.Customer.DataAccess;
using ZTG.Customer.ServiceModel;

namespace Customers.DataAccess
{
    public class CustomerRepository
   { 
        public List<Customer> Customers { get; set; }

        public CustomerRepository()
        {
            InitializeData();
        }

        public Customer GetById(int id)
        {
            return Customers.FirstOrDefault(x => x.Id == id);
        }

        public List<Customer> GetAll()
        {
            return Customers;
        }

        public Customer Save(Customer Customer)
        {
            Customers.Add(Customer);
            return Customer;
        }

        public void DeleteById(int id)
        {
            Customers.Remove(Customers.FirstOrDefault(x => x.Id == id));
        }

        public void InitializeData()
        {
            if (Customers != null)
            {
                Customers.Clear();
            }

            Customers = new List<Customer>();

            foreach (var customer in TestDataGenerator.GenerateTestData())
            {
                Customers.Add(customer);
            }
        }
    }
}