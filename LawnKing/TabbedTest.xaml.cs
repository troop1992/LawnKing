using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedTest : TabbedPage
    {
        public TabbedTest(string username, string password)
        {
            InitializeComponent();
            Children.Add(new Order());
            Children.Add(new OlderOrders(username,password));
            Children.Add(new Settings());
            //this.Children.Add(new MainPage());
            //this.Children.Add(new MainMenuCustomer());



        }
    }
}