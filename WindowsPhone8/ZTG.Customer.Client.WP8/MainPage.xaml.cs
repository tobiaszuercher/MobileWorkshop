using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ZTG.Customer.Client.WP8.Resources;

namespace ZTG.Customer.Client.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
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

        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
        }
    }
}