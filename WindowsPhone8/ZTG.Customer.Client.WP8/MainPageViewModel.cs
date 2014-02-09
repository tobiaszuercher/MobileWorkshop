using System.Collections.ObjectModel;
using ZTG.Customer.Client.WP8.Helper;

namespace ZTG.Customer.Client.WP8
{
    public class MainPageViewModel
    {
        private readonly CustomerUiService _customerUiService;

        public MainPageViewModel()
        {
            _customerUiService = App.CustomerUiService;
        }

        public ObservableCollection<CustomerViewModel> Customers
        {
            get { return _customerUiService.Customers; }
        }

        public ObservableCollection<AlphaKeyGroup<CustomerViewModel>> CustomersGroup
        {
            get { return _customerUiService.CustomersGroup; }
        }
    }
}
