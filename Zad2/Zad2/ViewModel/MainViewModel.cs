using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
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
        private ObservableCollection<LinguisticVariable> quantifiers;
        public ICommand GenerateCommand { get; set; }

        public MainViewModel()
        {
        }

        public MainViewModel(LiftingDataContext dataContext)
        {
            this.dataContext = dataContext;
            LinguisticVariables = StaticVariables.getAllVariables();
            quantifiers = StaticQuantifiers.getAllQuantifiers();
            GenerateCommand = new RelayCommand(o => Generate());
        }

        private void Generate()
        {
            List<KeyValuePair<double, string>> summaries = new List<KeyValuePair<double, string>>();
            foreach (var quantifier in quantifiers)
            {
                summaries.Add(new KeyValuePair<double, string>(
                    DegreeOfTruth.CalculateDOT(quantifier, SelectedQualifier, SelectedSummarizer, dataContext.Entry.ToList()),
                    quantifier.Name + " people being/having " + SelectedQualifier.MemberAndName + " are/have " + SelectedSummarizer.MemberAndName));
            }
            summaries.Sort((x, y) => y.Key.CompareTo(x.Key));
            int i = 1;
        }
    }
}
