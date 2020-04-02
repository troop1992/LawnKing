using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OlderOrders : ContentPage
    {
        public class Employee
        {
            public string DisplayName { get; set; }
        }
        public OlderOrders(string username, string password)
        {
            InitializeComponent();

            ListOfOrders.ItemsSource = "hellobeckycarson";
            EmployeeListPage();
        }

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public void EmployeeListPage()
        {
            ListOfOrders.ItemsSource = employees;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            employees.Add(new Employee { DisplayName = "3/22/2020 Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "3/23/2020 Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "3/25/2020 Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { DisplayName = "3/28/2020 Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "3/29/2020 Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "3/31/2020 Burt Indybrick" });
        }
    }
}