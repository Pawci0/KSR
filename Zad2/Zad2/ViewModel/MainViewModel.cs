using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        public ICommand SaveCommand { get; set; }
        public List<KeyValuePair<double, string>> Summaries { get; private set; }
        public string Output { get; private set; }

        public MainViewModel()
        {
        }

        public MainViewModel(LiftingDataContext dataContext)
        {
            this.dataContext = dataContext;
            LinguisticVariables = StaticVariables.getAllVariables();
            quantifiers = StaticQuantifiers.getAllQuantifiers();
            GenerateCommand = new RelayCommand(o => Generate());
            SaveCommand = new RelayCommand(o => Save());
        }

        private void Generate()
        {
            Summaries = new List<KeyValuePair<double, string>>();
            foreach (LinguisticVariable quantifier in quantifiers)
            {
                Summaries.Add(new KeyValuePair<double, string>(
                    DegreeOfTruth.CalculateDOT(quantifier, SelectedQualifier, SelectedSummarizer, dataContext.Entry.ToList()),
                    quantifier.Name + " people being/having " + SelectedQualifier.MemberAndName + " are/have " + SelectedSummarizer.MemberAndName));
            }
            Summaries.Sort((x, y) => y.Key.CompareTo(x.Key));
            string temp = "";
            foreach(KeyValuePair<double, string> summary in Summaries)
            {
                temp += summary.Value + " [" + summary.Key + "]\n";
            }
            Output = temp;
        }

        private void Save()
        {
            string path = "output.txt";
            
            if (!File.Exists(path))
            {
                File.WriteAllText(path, Output);
            }
        }
    }
}
