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

namespace SmartPocket
{
    public partial class ChargeEditPage : PhoneApplicationPage
    {
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
                }
                else if(NavigationContext.QueryString.TryGetValue("selectedIndex", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[index];
                }
            }
        }
    }
}