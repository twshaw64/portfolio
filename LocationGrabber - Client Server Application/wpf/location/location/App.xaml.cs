using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace location
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                var argsList = new List<string>();
                foreach (string arg in e.Args)
                {
                    argsList.Add(arg);
                }
                String[] args = argsList.ToArray();

                string output = Location.Main(args);
            }
            else
            {
                MainWindow window = new MainWindow();
                MainWindow.Show();
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }
}
