using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public class MainViewModel : INotifyPropertyChanged
    {
        private LiftingDataContext dataContext;
        public ObservableCollection<LinguisticVariable> LinguisticVariables { get; set; }

        public LinguisticVariable SelectedQualifier { get; set; }
        public LinguisticVariable SelectedSummarizer1 { get; set; }
        public LinguisticVariable SelectedSummarizer2 { get; set; }
        private ObservableCollection<LinguisticVariable> quantifiers;
        public ObservableCollection<LinguisticVariable> Andor { get; set; }

        public LinguisticVariable SelectedFunction { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GenerateCommand { get; set; }
        public ICommand Generate2Command { get; set; }
        public ICommand SaveCommand { get; set; }
        public List<KeyValuePair<double, string>> Summaries { get; private set; }
        public string Output { get => output;
            private set
            {
                output = value;
                OnPropertyChanged("Output");
            }
        }
        private string output;

        public MainViewModel()
        {
        }

        public MainViewModel(LiftingDataContext dataContext)
        {
            this.dataContext = dataContext;
            LinguisticVariables = StaticVariables.getAllVariables();
            quantifiers = StaticQuantifiers.getAllQuantifiers();
            GenerateCommand = new RelayCommand(o => Generate());
            Generate2Command = new RelayCommand(o => Generate2());
            SaveCommand = new RelayCommand(o => Save());
            Andor = new ObservableCollection<LinguisticVariable>
            {
                new LinguisticVariable
                {
                    Name = " OR ",
                    FuzzySet = new Or()
                },
                new LinguisticVariable
                {
                    Name = " AND ",
                    FuzzySet = new And()
                }
            };
        }

        private void Generate()
        {
            Summaries = new List<KeyValuePair<double, string>>();
            foreach (LinguisticVariable quantifier in quantifiers)
            {
                Summaries.Add(new KeyValuePair<double, string>(
                    Measures.AverageMeasure(quantifier, SelectedQualifier, SelectedSummarizer1, dataContext.Entry.ToList()),
                    quantifier.Name + " people being/having " + SelectedQualifier.MemberAndName + " are/have " + SelectedSummarizer1.MemberAndName));
            }
            Summaries.Sort((x, y) => y.Key.CompareTo(x.Key));
            string temp = "";
            foreach(KeyValuePair<double, string> summary in Summaries)
            {
                temp += summary.Value + " [" + summary.Key + "]\n";
            }
            Output = temp;
        }

        private void Generate2()
        {
            Summaries = new List<KeyValuePair<double, string>>();
            SelectedFunction.FuzzySet.SetAllFuzzySets(new List<FuzzySet> { SelectedSummarizer1.FuzzySet, SelectedSummarizer2.FuzzySet });
            foreach (LinguisticVariable quantifier in quantifiers)
            {
                Summaries.Add(new KeyValuePair<double, string>(
                    Measures.AverageMeasure(quantifier, SelectedQualifier, SelectedFunction, dataContext.Entry.ToList()),
                    quantifier.Name + " people being/having " + SelectedQualifier.MemberAndName + " are/have " + 
                    SelectedSummarizer1.MemberAndName + SelectedFunction.Name + SelectedSummarizer2.MemberAndName));
            }
            Summaries.Sort((x, y) => y.Key.CompareTo(x.Key));
            string temp = "";
            foreach (KeyValuePair<double, string> summary in Summaries)
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

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
