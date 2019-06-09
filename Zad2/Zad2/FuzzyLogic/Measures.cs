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
            var fuzzySets = summarizer.FuzzySet.GetAllFuzzySets();
            foreach (var set in fuzzySets)
            {
                ret *= set.DegreeOfFuzziness(entries);
            }
            ret = Math.Pow(ret, 1 / fuzzySets.Count);
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
            //todo
            throw new NotImplementedException();
        }

        //T5
        public static double LengthOfSummary(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            var nOfSummarizers = summarizer.FuzzySet.GetAllFuzzySets().Count;
            return 2 * Math.Pow(1.0 / 2.0, nOfSummarizers);
        }

        //T6
        public static double DegreeOfQuantifierImprecision(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            var ret = (quantificator.MembershipFunction.Parameters.Last()
                       - quantificator.MembershipFunction.Parameters.First());

            if (quantificator.Absolute)
            {
                ret /= (double) entries.Count;
            }
            return 1 - ret;
        }

        //T7
        public static double DegreeOfQuantifierCardinality(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double ret = quantificator.MembershipFunction.Cardinality();
            if (quantificator.Absolute)
            {
                ret /= (double)entries.Count;
            }
            return 1 - ret;
        }

        //T8
        public static double DegreeOfSummarizerCardinality(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            double ret = 1;
            var fuzzySets = summarizer.FuzzySet.GetAllFuzzySets();
            foreach (var set in fuzzySets)
            {
                ret *= set.Cardinality() / entries.Count;
            }
            ret = Math.Pow(ret, 1.0 / fuzzySets.Count);
            return 1 - ret;
        }

        //T9
        public static double DegreeOfQualifierImprecision(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            return 1 - qualifier.FuzzySet.DegreeOfFuzziness(entries);
        }

        //T10
        public static double DegreeOfQualifierCardinality(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            return 1 - (qualifier.FuzzySet.Cardinality() / entries.Count);
        }

        //T11
        public static double LengthOfQualifier(LinguisticVariable quantificator, LinguisticVariable qualifier, LinguisticVariable summarizer, List<Entry> entries)
        {
            var nOfSummarizers = qualifier.FuzzySet.GetAllFuzzySets().Count;
            return 2 * Math.Pow(1.0 / 2.0, nOfSummarizers);
        }
    }
}
