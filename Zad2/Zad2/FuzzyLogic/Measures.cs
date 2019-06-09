using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.DataModel;

namespace Zad2.FuzzyLogic
{
    public class Measures
    {
        public static double DegreeOfTruth(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double up = 0;
            double down = 0;
            foreach(Entry e in entries)
            {
                up += Math.Min(qualifier.GetMemebership(e), summarizer.GetMemebership(e));
                down += qualifier.Extractor(e);
            }
            if(quantificator.Absolute)
                return quantificator.MembershipFunction.GetMembership(up);
            return quantificator.MembershipFunction.GetMembership(up / down);
        }

        public static double DegreeOfImprecision(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double ret=1;
            var xd = summarizer.FuzzySet.DegreeOfFuzzinessForAllFunctions(entries);
            foreach (var DoF in xd)
            {
                ret *= DoF;
            }
            ret = Math.Pow(ret, 1 / xd.Count);
            return 1 - ret;
        }
    }
}
