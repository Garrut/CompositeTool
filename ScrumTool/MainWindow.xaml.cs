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
        
        public MainWindow()
        {
            InitializeComponent();
            

            IEmployee Henk = new SoftwareEngineer("Henk", 54);
            IEmployee Gerard = new SoftwareEngineer("Gerard", 30);
            IEmployee Peter = new SoftwareEngineer("Peter", 28);
            IEmployee Pieter = new SoftwareArchitect("Pieter", 43);
            
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
