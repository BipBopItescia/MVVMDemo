using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModel
{
    class CustomerViewModel
    {
        public ObservableCollection<Customer> Customers
        {
            get;
            set;
        }

        public void LoadCustomers()
        {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

            customers.Add(new Customer { FirstName = "Anthony", LastName = "Custodio" });
            customers.Add(new Customer { FirstName = "Arnaud", LastName = "Chretien" });
            customers.Add(new Customer { FirstName = "Adrien", LastName = "Grandpierre" });
            customers.Add(new Customer { FirstName = "Lucas", LastName = "Burette" });
            customers.Add(new Customer { FirstName = "Viktor", LastName = "Stoyanov" });

            Customers = customers;
        }


    }
}
