using System;
using System.Collections.Generic;
using System.Linq;
using Zad2.DataModel;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    public class And : FuzzySet
    {
        public FuzzySet fuzzySet1;
        public FuzzySet fuzzySet2;

        public override double GetMembership(Entry entry)
        {
            return Math.Min(fuzzySet1.GetMembership(entry), fuzzySet2.GetMembership(entry));
        }

        public override List<Entry> Support(List<Entry> entries)
        {
            return fuzzySet1.Support(entries).Intersect(fuzzySet2.Support(entries)).ToList(); ;
        }

        public override double DegreeOfFuzziness(List<Entry> entries)
        {
            return fuzzySet1.DegreeOfFuzziness(entries) * fuzzySet2.DegreeOfFuzziness(entries);
        }

        public override List<FuzzySet> GetAllFuzzySets()
        {
            return fuzzySet1.GetAllFuzzySets().Concat(fuzzySet2.GetAllFuzzySets()).ToList();
        }

        public override void SetAllFuzzySets(List<FuzzySet> sets)
        {
            fuzzySet1 = sets[0];
            fuzzySet2 = sets[1];
        }
    }
}
