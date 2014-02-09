using System;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace ZTG.Customer.Client.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainPageViewModel();
        }

        public MainPageViewModel ViewModel
        {
            get { return DataContext as MainPageViewModel; }
            set { DataContext = value; }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            App.CustomerUiService.LoadCustomers();
            base.OnNavigatedTo(e);
        }

        private void _customerList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_customerList.SelectedItem != null)
            {
                var customerViewModel = (_customerList.SelectedItem as CustomerViewModel);
                NavigationService.Navigate(new Uri("/CustomerDetailPage.xaml?ID=" + customerViewModel.Id, UriKind.Relative));
            }
        }
    }
}