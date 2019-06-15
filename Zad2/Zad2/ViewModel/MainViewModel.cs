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
        public List<KeyValuePair<double, (string summary, List<double> tValues)>> Summaries { get; private set; }
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
            Summaries = new List<KeyValuePair<double, (string, List<double>)>>();
            foreach (LinguisticVariable quantifier in quantifiers)
            {
                string summary = quantifier.Name + " of people being/having " + SelectedQualifier.MemberAndName + " are/have " + SelectedSummarizer1.MemberAndName;
                var pair = CreateSummaryPair(quantifier, SelectedSummarizer1, summary);
                Summaries.Add(pair);
            }
            Summaries.Sort((x, y) => y.Key.CompareTo(x.Key));
            Output = GenerateSummarySentences();
        }

        private KeyValuePair<double, (string, List<double>)> CreateSummaryPair(LinguisticVariable quantifier, LinguisticVariable summarizer, string summary)
        {
            List<double> measureValues;
            var weightedMeasure = Measures.WeightedMeasure(quantifier, SelectedQualifier, summarizer, dataContext.Entry.ToList(), out measureValues);
            var pair = new KeyValuePair<double, (string, List<double>)>(
                weightedMeasure,
                (summary, measureValues)
            );
            return pair;
        }

        private void Generate2()
        {
            Summaries = new List<KeyValuePair<double, (string, List<double>)>>();
            SelectedFunction.FuzzySet.SetAllFuzzySets(new List<FuzzySet> { SelectedSummarizer1.FuzzySet, SelectedSummarizer2.FuzzySet });
            foreach (LinguisticVariable quantifier in quantifiers)
            {
                string summary = quantifier.Name + " of people being/having " + SelectedQualifier.MemberAndName + " are/have " +
                    SelectedSummarizer1.MemberAndName + SelectedFunction.Name + SelectedSummarizer2.MemberAndName;
                var pair = CreateSummaryPair(quantifier, SelectedFunction, summary);
                Summaries.Add(pair);
            }
            Summaries.Sort((x, y) => y.Key.CompareTo(x.Key));
            Output = GenerateSummarySentences();
        }

        private string GenerateSummarySentences()
        {
            string res = "";
            foreach (var summary in Summaries)
            {
                LogTValues(summary.Value.summary, summary.Value.tValues);
                int i = 1;
                res += summary.Value.summary + " [" + Math.Round(summary.Key, 3) + "]\n";
                res += "[";
                summary.Value.tValues.ForEach((v) => {
                    res += "T" + i++ + "=" + Math.Round(v, 3) + "; ";
                });
                res = res.Substring(0, res.Length - 2);
                res += "]\n";
            }

            return res;
        }

        private void LogTValues(string summary, List<double> tValues)
        {
            string log = summary + ":\n";
            tValues.ForEach((v) => log += Math.Round(v, 3) + ", ");
            System.Diagnostics.Trace.WriteLine(log.Substring(0, log.Length - 2));
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
