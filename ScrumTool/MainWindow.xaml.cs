using ScrumTool.Composite;
using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();

            
            SoftwareArchitect arc = new SoftwareArchitect("henk");
            SoftwareEngineer sof = new SoftwareEngineer("arjen");
            SoftwareArchitect arc1 = new SoftwareArchitect("shenk");
            SoftwareArchitect arc2 = new SoftwareArchitect("shenki");
            SoftwareEngineer sof1 = new SoftwareEngineer("arjan");
            SoftwareEngineer sof2 = new SoftwareEngineer("arjun");
            TeamLead lead = new TeamLead("jaap");

            lead.Add(sof);
            lead.Add(arc);
            listOfEmployeesByTeamlead = lead.employeeList;
            //listOfEmployees.ItemsSource = lead.employeeList;
            

        }


    }
}
