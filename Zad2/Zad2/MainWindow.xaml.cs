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
using Zad2.FuzzyLogic;

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
            @"Data Source=D:\Studia\ksr\KSR\Zad2\db");
            var context = new LiftingDataContext(connection);
            double aaaaaaaaa = DegreeOfTruth.CalculateDOT(StaticVariables.lessThan5000, StaticVariables.genderMale, StaticVariables.ageYoung, context.Entry.ToList());
            aaaaaaaaa++;
        }
    }
}
