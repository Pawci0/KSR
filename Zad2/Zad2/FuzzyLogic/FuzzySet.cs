using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.DataModel;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    public class FuzzySet
    {
        public IMembershipFunction MembershipFunction { get; set; }
        public Func<Entry, double> FieldExtractor { get; set; }

        public double GetMembership(Entry entry)
        {
            return MembershipFunction.GetMembership(FieldExtractor(entry));
        }
    }
}
