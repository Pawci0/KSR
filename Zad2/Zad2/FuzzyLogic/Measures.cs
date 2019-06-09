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
        //T1
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

        //T2
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

        //T3
        public static double DegreeOfCovering(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double up = 0;
            double down = 0;

            foreach (var entry in entries)
            {
                var qualVal = qualifier.GetMemebership(entry);
                var sumVal = summarizer.GetMemebership(entry);
                if (qualVal > 0)
                {
                    down++;
                    if(sumVal > 0)
                    {
                        up++;
                    }
                }
            }

            return up / down;
        }

        //T4
        public static double DegreeOfAppropriateness(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double ret = 0;
            var sets = summarizer.FuzzySet.GetAllFuzzySets();
            double t3 = DegreeOfCovering(quantificator, qualifier, summarizer, entries);
            foreach (var set in sets)
            {
                ret += (set.Support(entries).Count() / entries.Count()) - t3;
            }
            return Math.Abs(ret);
        }

        //T5
        public static double LengthOfSummary(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            var nOfSummarizers = summarizer.MembershipFunction.GetAllFunctions().Count;
            return 2 * Math.Pow(1.0 / 2.0, nOfSummarizers);
        }

        //T6
        public static double DegreeOfQuantifierImprecision(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double ret = quantificator.FuzzySet.Support(entries).Count;
            if (!quantificator.Absolute)
            {
                ret /= (double) entries.Count;
            }
            return ret;
        }

        //T7
        public static double DegreeOfQuantifierCardinality(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double ret = quantificator.FuzzySet.Cardinality();
            if (!quantificator.Absolute)
            {
                ret /= (double)entries.Count;
            }
            return ret;
        }
    }
}
