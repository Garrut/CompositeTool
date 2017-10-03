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
        TeamLead lead = new TeamLead("jaap");
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<IEmployee> AllEmployeeList = new ObservableCollection<IEmployee>();
            SoftwareArchitect arc = new SoftwareArchitect("henk");
            SoftwareEngineer sof = new SoftwareEngineer("arjen");
            SoftwareArchitect arc1 = new SoftwareArchitect("shenk");
            SoftwareArchitect arc2 = new SoftwareArchitect("shenki");
            SoftwareEngineer sof1 = new SoftwareEngineer("arjan");
            SoftwareEngineer sof2 = new SoftwareEngineer("arjun");
           

            AllEmployeeList.Add(arc);
            AllEmployeeList.Add(arc1);
            AllEmployeeList.Add(arc2);
            AllEmployeeList.Add(sof);
            AllEmployeeList.Add(sof1);
            AllEmployeeList.Add(sof2);
            AllEmployeeList.Add(lead);
            lead.Add(sof);
            lead.Add(arc);
           
            listOfEmployees.ItemsSource = AllEmployeeList;
            

        }

        private void listOfEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the currently selected item in the ListBox.
            IEmployee curItem = (IEmployee)listOfEmployees.SelectedItem;
            if(curItem.jobRole == "Team leader")
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
