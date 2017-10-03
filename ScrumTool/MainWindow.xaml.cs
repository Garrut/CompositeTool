using ScrumTool.Composite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScrumTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeamLead lead;

        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<IEmployee> AllEmployeeList = new ObservableCollection<IEmployee>();
            
            IEmployee Henk = new SoftwareEngineer("Henk", 54);
            IEmployee Gerard = new SoftwareEngineer("Gerard", 30);
            IEmployee Peter = new SoftwareEngineer("Peter", 28);
            IEmployee Pieter = new SoftwareArchitect("Pieter", 43);

            AllEmployeeList.Add(Henk);
            AllEmployeeList.Add(Gerard);
            AllEmployeeList.Add(Pieter);
            AllEmployeeList.Add(Peter);

            lead = new TeamLead(Henk);
            lead.Add(Gerard);
            lead.Add(Henk);
            lead.Add(Peter);
           
            listOfEmployees.ItemsSource = AllEmployeeList;
        }

        private void listOfEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IEmployee curItem;

            // Get the currently selected item in the ListBox.
            curItem = (IEmployee)listOfEmployees.SelectedItem;
            if(curItem.Job  == "Team leader")
            {
                listOfEmployeesByTeamlead.ItemsSource = lead.employeeList;
            }
            else
            {
                listOfEmployeesByTeamlead.ItemsSource = null;
            }

          
        }
    }
}
