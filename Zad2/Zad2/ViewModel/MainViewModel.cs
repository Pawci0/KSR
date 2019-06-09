using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.DataModel;
using Zad2.FuzzyLogic;

namespace Zad2.ViewModel
{
    public class MainViewModel
    {
        private LiftingDataContext dataContext;
        public ObservableCollection<LinguisticVariable> LinguisticVariables { get; set; }

        public LinguisticVariable SelectedQualifier { get; set; }
        public LinguisticVariable SelectedSummarizer { get; set; }

        public MainViewModel()
        {
        }

        public MainViewModel(LiftingDataContext dataContext)
        {
            this.dataContext = dataContext;
            LinguisticVariables = StaticVariables.getAllVariables();
        }

        public void generate()
        {

        }
    }
}
