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
    /// 

    public partial class MainWindow : Window
    {
        ObservableCollection<IEmployee> AllEmployeeList = Employees.returnEmployees();
        private TeamLead curItem = null;
        private IEmployee selectedItem = null;

        public MainWindow()
        {
            InitializeComponent();
            
            SoftwareEngineer Henk = new SoftwareEngineer("Henk", 54);
            SoftwareEngineer Gerard = new SoftwareEngineer("Gerard", 30);
            SoftwareEngineer Peter = new SoftwareEngineer("Peter", 28);
            SoftwareArchitect Pieter = new SoftwareArchitect("Pieter", 43);
            TeamLead Jan = new TeamLead(new SoftwareArchitect("Jan", 50));
            TeamLead Pierri = new TeamLead(new SoftwareArchitect("Pierri", 50));
            Jan.Add(Gerard);

            listOfEmployees.ItemsSource = AllEmployeeList;
            updateCombo();
        }

        private void updateCombo()
        {
            teamleaders.ItemsSource = AllEmployeeList.Where(x => x.GetType() == typeof(TeamLead));
        }

        #region Form control actions
        private void listOfEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //item == curitem
            selectedItem = (IEmployee)listOfEmployees.SelectedItem;

            if (selectedItem == null)
            {
                return;
            }

            try
            {
                curItem = (TeamLead)listOfEmployees.SelectedItem;
                listOfEmployeesByTeamlead.ItemsSource = curItem.employeeList;
            }
            catch (InvalidCastException)
            {
                curItem = null;
                listOfEmployeesByTeamlead.ItemsSource = null;
            }
        }

        private void teamleaders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addToSelectedTeamleader_Click(object sender, RoutedEventArgs e)
        {
            var selectedLead = teamleaders.SelectedItem as TeamLead;
            if ((selectedLead.employeeList.Contains(selectedItem)))
            {
                MessageBoxResult result = MessageBox.Show("This lead already contains selected employee");
                return;
            }

            if (selectedLead == selectedItem)
            {
                MessageBoxResult result = MessageBox.Show("A teamlead can't be added to his own team");
                return;
            }
            else
            {
                selectedLead.Add(selectedItem);
            }
        }

        private void RmEmployeeFromGroup_Click(object sender, RoutedEventArgs e)
        {
            var x = (TeamLead)listOfEmployees.SelectedItem;
            x.Remove(listOfEmployeesByTeamlead.SelectedItem as IEmployee);
        }

        private void TeamLeader_Btn_Click(object sender, RoutedEventArgs e)
        {
            if(listOfEmployees.SelectedItem.GetType() != typeof(TeamLead))
            {
                TeamLead n = new TeamLead((IEmployee)listOfEmployees.SelectedItem);
                updateCombo();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Is already a teamlead!");
            }
        }
        #endregion
    }
}
