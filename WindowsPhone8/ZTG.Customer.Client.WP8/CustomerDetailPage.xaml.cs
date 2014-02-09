using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ZTG.Customer.Client.WP8
{
    public partial class CustomerDetailPage : PhoneApplicationPage
    {
        public CustomerDetailPage()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }

        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
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