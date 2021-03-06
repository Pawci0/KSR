﻿using System;
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

        public virtual double GetMembership(Entry entry)
        {
            return MembershipFunction.GetMembership(FieldExtractor(entry));
        }

        private  List<Entry> Support(List<Entry> entries, IMembershipFunction function)
        {
            List<Entry> result = new List<Entry>();
            entries.ForEach((e) => {
                if (function.GetMembership(FieldExtractor(e)) > 0)
                {
                    result.Add(e);
                }
            });
            return result;
        }

        public virtual List<Entry> Support(List<Entry> entries)
        {
            return Support(entries, MembershipFunction);
        }

        private double DegreeOfFuzziness(List<Entry> entries, IMembershipFunction function)
        {
            return (double) Support(entries, function).Count / (double) entries.Count;
        }

        public virtual double DegreeOfFuzziness(List<Entry> entries)
        {
            return DegreeOfFuzziness(entries, MembershipFunction);
        }

        public virtual double Cardinality()
        {
            return MembershipFunction.Cardinality();
        }

        public virtual List<FuzzySet> GetAllFuzzySets()
        {
            return new List<FuzzySet> { this };
        }

        public virtual void SetAllFuzzySets(List<FuzzySet> sets)
        {
            
        }
    }
}
