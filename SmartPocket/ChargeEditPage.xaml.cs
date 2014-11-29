using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SmartPocket.Resources;
using SmartPocket.ViewModels;

namespace SmartPocket
{
    public partial class ChargeEditPage : PhoneApplicationPage
    {
        private bool isExisting;
        private int _index;
        public ChargeEditPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                string isIncome = "";
                if (NavigationContext.QueryString.TryGetValue("isIncome", out isIncome))
                {
                    if (isIncome.ToLower() == "true")
                    {
                        this.PageTitle.Text = AppResources.Income;
                    }
                    else
                    {
                        this.PageTitle.Text = AppResources.Outcome;
                    }
                    isExisting = false;
                }
                else if(NavigationContext.QueryString.TryGetValue("selectedIndex", out selectedIndex))
                {
                    _index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[_index];
                    isExisting = true;
                }
            }
        }
        private void ApplicationBarSave_Click(object sender, EventArgs e)
        {
            if (isExisting)
            {
                
                App.ViewModel.Items[_index].Amount = Double.Parse(ChargeAmountTextBox.Text);
                App.ViewModel.Items[_index].Description = ChargeDescriptionTextBox.Text;
               // App.ViewModel.Items[_index].*/
                App.ViewModel.SubmitChanges();
                if (this.NavigationService.CanGoBack)
                {
                    this.NavigationService.GoBack();
                }
            }
            else
            {
                ChargeViewModel charge = new ChargeViewModel();
                charge.Amount = Double.Parse(ChargeAmountTextBox.Text);
                charge.Description = ChargeDescriptionTextBox.Text;
                App.ViewModel.AddToDoItem(charge);
                if (this.NavigationService.CanGoBack)
                {
                    this.NavigationService.GoBack();
                }
            }
        }
    }
}