using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;

namespace DxBlazorApplication.Data
{
    public class CustomerStore : IDisposable
    {
        readonly ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        public CustomerStore()
        {
            var dataPath = Path.GetDirectoryName(typeof(CustomerStore).Assembly.Location);
            string file = Path.Combine(dataPath, "Data.json");
            if (File.Exists(file))
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(file)))
                {
                    var data = System.Text.Json.JsonSerializer.Deserialize<Customer[]>(stream);
                    customers = new ObservableCollection<Customer>(data!);
                }
            }
            customers.CollectionChanged += NotifyCustomersChanged;
        }
        public IEnumerable<Customer> Customers => customers;

        public event NotifyCollectionChangedEventHandler CustomersChanged;
        void NotifyCustomersChanged(object sender, NotifyCollectionChangedEventArgs e)
            => CustomersChanged?.Invoke(sender, e);

        public void Add(Customer customer)
        {
            lock (customers)
            {
                customer.customer_id = customers?.Count() > 0 ? customers.Max(c => c.customer_id) + 1 : 1;
                customers.Add(customer);
            }
        }

        public void Update(Customer customer)
        {
            lock (customers)
            {
                var index = customers.IndexOf(customers.First(c => c.customer_id == customer.customer_id));
                if (index >= 0)
                    customers[index] = customer;
            }
        }
        public void Remove(Customer customer)
        {
            lock (customers)
            {
                var index = customers.IndexOf(customers.First(c => c.customer_id == customer.customer_id));
                if (index >= 0)
                    customers.RemoveAt(index);
            }
        }

        public void Clear()
        {
            lock (customers)
            {
                customers.Clear();
            }
        }

        public void Dispose()
        {
            Clear();
            customers.CollectionChanged -= NotifyCustomersChanged;
        }
    }


    public class Customer
    {
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string phone_number { get; set; }
        public string avatar { get; set; }
    }

}
