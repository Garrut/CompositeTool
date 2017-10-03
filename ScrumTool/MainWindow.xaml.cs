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
        TeamLead testLead;
        TeamLead curItem;

        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<IEmployee> AllEmployeeList = new ObservableCollection<IEmployee>();
            //ObservableCollection<TeamLead> AllTeamLeadsList = new ObservableCollection<TeamLead>();
            

            IEmployee Henk = new SoftwareEngineer("Henk", 54);
            IEmployee Gerard = new SoftwareEngineer("Gerard", 30);
            IEmployee Peter = new SoftwareEngineer("Peter", 28);
            IEmployee Pieter = new SoftwareArchitect("Pieter", 43);
            lead = new TeamLead(Henk);
            testLead = new TeamLead(Gerard);
            //AllEmployeeList.Add(Henk);
            //AllEmployeeList.Add(Gerard);
            AllEmployeeList.Add(Pieter);
            AllEmployeeList.Add(Peter);
            AllEmployeeList.Add(lead);
            AllEmployeeList.Add(testLead);

            testLead.Add(Peter);
            
            lead.Add(Gerard);
            lead.Add(Henk);
            lead.Add(Peter);
           
            listOfEmployees.ItemsSource = AllEmployeeList;
        }

        private void listOfEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                curItem = (TeamLead)listOfEmployees.SelectedItem;
                listOfEmployeesByTeamlead.ItemsSource = curItem.employeeList;
            }
            catch (InvalidCastException ) {
                listOfEmployeesByTeamlead.ItemsSource = null;
            }
           

          
        }
    }
}
