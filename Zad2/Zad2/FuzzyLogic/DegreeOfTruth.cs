using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.DataModel;

namespace Zad2.FuzzyLogic
{
    public class DegreeOfTruth
    {
        public static double CalculateDOT(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double up = 0;
            double down = 0;
            foreach(Entry e in entries)
            {
                up += Math.Min(qualifier.Extractor(e), summarizer.Extractor(e));
                down += qualifier.Extractor(e);
            }
            return quantificator.MembershipFunction.GetMembership(up / down);
        }
    }
}
