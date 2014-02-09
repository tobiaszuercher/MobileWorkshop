using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

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
    }
}