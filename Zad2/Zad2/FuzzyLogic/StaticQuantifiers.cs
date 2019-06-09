using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    public class StaticQuantifiers
    {
        #region Quantizers
        //relative
        public static LinguisticVariable few = new LinguisticVariable
        {
            Name = "Few",
            MembershipFunction = new TriangularFunction(new List<double> { 0, 0.15, 0.3 }),
            Absolute = false
        };
        public static LinguisticVariable lessThanThird = new LinguisticVariable
        {
            Name = "Less than a third",
            MembershipFunction = new TrapezoidFunction(new List<double> { 0, 0, 0.3, 0.35 }),
            Absolute = false
        };
        public static LinguisticVariable aroundHalf = new LinguisticVariable
        {
            Name = "Around half",
            MembershipFunction = new TriangularFunction(new List<double> { 0.4, 0.5, 0.6 }),
            Absolute = false
        };
        public static LinguisticVariable majority = new LinguisticVariable
        {
            Name = "Majority",
            MembershipFunction = new TriangularFunction(new List<double> { 0.75, 0.8, 0.9 }),
            Absolute = false
        };
        public static LinguisticVariable almostAll = new LinguisticVariable
        {
            Name = "All",
            MembershipFunction = new TrapezoidFunction(new List<double> { 0.85, 0.9, 1, 1 }),
            Absolute = false
        };

        //absolute
        public static LinguisticVariable around3000 = new LinguisticVariable
        {
            Name = "Around 3000",
            MembershipFunction = new TriangularFunction(new List<double> { 2500, 3000, 3500 }),
            Absolute = true
        };
        public static LinguisticVariable lessThan5000 = new LinguisticVariable
        {
            Name = "Less than 5000",
            MembershipFunction = new TriangularFunction(new List<double> { 0, 0, 5000 }),
            Absolute = true
        };
        public static LinguisticVariable moreThan10000 = new LinguisticVariable
        {
            Name = "Much more than 10000",
            MembershipFunction = new TrapezoidFunction(new List<double> { 10000, 15000, 45000, 45000 }),
            Absolute = true
        };
        #endregion
        public static ObservableCollection<LinguisticVariable> getAllQuantifiers()
        {
            return new ObservableCollection<LinguisticVariable>
            {
                few,
                lessThanThird,
                aroundHalf,
                majority,
                almostAll,
                around3000,
                lessThan5000,
                moreThan10000
            };
        }
    }
}
