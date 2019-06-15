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
using Zad2.ViewModel;

namespace Zad2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel viewModel;
        private LiftingDataContext context;
        public MainWindow()
        {
            InitializeComponent();
            var connection = new SqliteConnection(
            @"Data Source=..\..\..\db");
            context = new LiftingDataContext(connection);
            viewModel = new MainViewModel(context);
            DataContext = viewModel;
            Loaded += Onloaded;
        }

        private void Onloaded(object sender, RoutedEventArgs e)
        {
            double aaaaaaaaa = Measures.LengthOfQualifier(StaticQuantifiers.lessThan5000, 
                                                                    StaticVariables.genderMale, 
                                                                    StaticVariables.ageYoung, 
                                                                    context.Entry.ToList());

        }
    }
}
