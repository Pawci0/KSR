using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Linq;
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
using Zad2.DataModel;

namespace Zad2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += Onloaded;
        }

        private void Onloaded(object sender, RoutedEventArgs e)
        {
            var connection = new SqliteConnection(
            @"Data Source=C:\Users\Paweł\source\repos\ksr\Zad2\db");
            var context = new LiftingDataContext(connection);
            foreach (var company in context.Entry)
            {

            }
        }
    }
}
