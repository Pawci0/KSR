using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.DataModel;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    public class LinguisticVariable
    {
        public string Name { get; set; }
        public IMembershipFunction MembershipFunction { get; set; }
        public string MemberToExtract { get; set; }
        public Func<Entry, double> Extractor { get; set; }
        public bool Absolute { get; set; }
        public FuzzySet FuzzySet { get; set; }

        public double GetMemebership(Entry entry)
        {
            return FuzzySet.GetMembership(entry);
        }
        public string MemberAndName { get => MemberToExtract + ": " + Name; }
    }
}
