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
using location;

namespace location
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            var argsList = new List<string>();

            switch (cboProtocol.SelectedIndex) //protocol
            {
                case 0:
                    break;
                case 1:
                    argsList.Add("-h9");
                    break;
                case 2:
                    argsList.Add("-h0");
                    break;
                case 3:
                    argsList.Add("-h1");
                    break;
            }

            argsList.Add(txtName.Text); //name

            if (txtHost.Text != "")
            {
                argsList.Add("-h"); //host
                argsList.Add(txtHost.Text);
            }

            if (txtPort.Text != "")
            {
                argsList.Add("-p"); //port
                argsList.Add(txtPort.Text);
            }

            if (txtTimeout.Text != "")
            {
                argsList.Add("-t"); //timeout
                argsList.Add(txtTimeout.Text);
            }

            String[] args = argsList.ToArray(); //convert list to array

            string output = Location.Main(args); //run main method

            MessageBox.Show(output); //show output in a messagebox

            argsList.Clear(); //clear list so program can be run again without restarting
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            var argsList = new List<string>();

            switch (cboProtocol.SelectedIndex) //protocol
            {
                case 0:
                    break;
                case 1:
                    argsList.Add("-h9");
                    break;
                case 2:
                    argsList.Add("-h0");
                    break;
                case 3:
                    argsList.Add("-h1");
                    break;
            }

            argsList.Add(txtName.Text); //name
            argsList.Add(txtLocation.Text); //location

            if (txtHost.Text != "")
            {
                argsList.Add("-h"); //host
                argsList.Add(txtHost.Text);
            }

            if (txtPort.Text != "")
            {
                argsList.Add("-p"); //port
                argsList.Add(txtPort.Text);
            }

            if (txtTimeout.Text != "")
            {
                argsList.Add("-t"); //timeout
                argsList.Add(txtTimeout.Text);
            }

            String[] args = argsList.ToArray(); //convert list to array

            string output = Location.Main(args); //run main method

            MessageBox.Show(output); //show output in a messagebox

            argsList.Clear(); //clear list so program can be run again without restarting
        }
    }
}
