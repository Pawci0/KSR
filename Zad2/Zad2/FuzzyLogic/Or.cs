using System;
using System.Collections.Generic;
using System.Linq;
using Zad2.DataModel;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    class Or : FuzzySet
    {
        FuzzySet fuzzySet1;
        FuzzySet fuzzySet2;

        public new double GetMembership(Entry entry)
        {
            return Math.Max(fuzzySet1.GetMembership(entry), fuzzySet2.GetMembership(entry));
        }

        public new List<Entry> Support(List<Entry> entries)
        {
            return fuzzySet1.Support(entries).Concat(fuzzySet2.Support(entries)).Distinct().ToList();
        }

        public new double DegreeOfFuzziness(List<Entry> entries)
        {
            return fuzzySet1.DegreeOfFuzziness(entries) * fuzzySet2.DegreeOfFuzziness(entries);
        }
    }
}
