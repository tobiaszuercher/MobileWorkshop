using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ZTG.Customer.Client.WP8.Resources;

namespace ZTG.Customer.Client.WP8
{
    public partial class CustomerDetailPage : PhoneApplicationPage
    {
        public CustomerDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var customerId = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("ID", out customerId))
            {
                App.CustomerUiService.SelectCustomer(Convert.ToInt32(customerId));
                DataContext = App.CustomerUiService.SelectedCustomer;
            }
        }

        /// <summary>
        /// Updates the binding of the current focused element.
        /// The changes in the current TextBox will not be saved if you do not call UpdateSource 
        /// </summary>
        private void UpdateFocusedElement()
        {
            var element = FocusManager.GetFocusedElement() as TextBox;
            if (element != null)
            {
                var binding = element.GetBindingExpression(TextBox.TextProperty);
                binding.UpdateSource();
            }
        }
    }
}