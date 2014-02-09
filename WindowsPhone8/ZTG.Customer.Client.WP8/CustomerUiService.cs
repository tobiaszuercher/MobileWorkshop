using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;
using ZTG.Customer.Client.WP8.Helper;

namespace ZTG.Customer.Client.WP8
{
    public class CustomerUiService : NotificationObject
    {
        private readonly RestHelper _restClient;

        public CustomerUiService()
        {
            Customers = new ObservableCollection<CustomerViewModel>();
            CustomersGroup = new ObservableCollection<AlphaKeyGroup<CustomerViewModel>>();
            _restClient = new RestHelper(Settings.BaseUrl);
        }

        public CustomerViewModel SelectedCustomer { get; private set; }

        public ObservableCollection<CustomerViewModel> Customers { get; private set; }

        public ObservableCollection<AlphaKeyGroup<CustomerViewModel>> CustomersGroup { get; private set; }

        public void LoadCustomers()
        {
            SelectedCustomer = null;
            Customers.Clear();
            _restClient.Get<List<Model.Customer>>(Callback);
        }

        private void Callback(List<Model.Customer> listOfCustomer)
        {
            if (listOfCustomer != null)
            {
                foreach (var customer in listOfCustomer.OrderBy(x => x.FirstName).OrderBy(x => x.LastName))
                {
                    Customers.Add(new CustomerViewModel(customer));
                }

                var groups = AlphaKeyGroup<CustomerViewModel>.CreateGroups(Customers, System.Threading.Thread.CurrentThread.CurrentUICulture, s => { return s.LastName; }, true);

                foreach (var group in groups)
                {
                    CustomersGroup.Add(group);
                }
            }
        }

        public void SelectCustomer(int customerId)
        {
            SelectedCustomer = Customers.First(x => x.Id == customerId);
        }

        public void SaveSelectedCustomer()
        {
            if (SelectedCustomer != null)
            {
                _restClient.Put(SelectedCustomer);
            }
        }

        public void DeleteSelectedCustomer()
        {
            if (SelectedCustomer != null)
            {
                _restClient.Delete<CustomerViewModel>(SelectedCustomer.Id);
                Customers.Remove(SelectedCustomer);
                SelectedCustomer = null;
            }
        }

        public int NewCustomer()
        {
            var id = Customers.Max(x => x.Id) + 1;
            var newCustomer = new CustomerViewModel(new Model.Customer()
                {
                    FirstName = "New",
                    Id = id
                });
            _restClient.Post(newCustomer);
            Customers.Add(newCustomer);
            SelectedCustomer = newCustomer;
            return id;
        }
    }
}
