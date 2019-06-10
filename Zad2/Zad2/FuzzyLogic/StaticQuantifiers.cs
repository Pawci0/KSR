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
        public static LinguisticVariable no = new LinguisticVariable
        {
            Name = "No",
            MembershipFunction = new TriangularFunction(new List<double> { 0, 0, 0.15 }),
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
        public static LinguisticVariable aroundThreeQuaters = new LinguisticVariable
        {
            Name = "Around three quaters",
            MembershipFunction = new TriangularFunction(new List<double> { 0.5, 0.6, 0.7 }),
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
        public static LinguisticVariable lessThan5000 = new LinguisticVariable
        {
            Name = "Less than 5000",
            MembershipFunction = new TrapezoidFunction(new List<double> { 0, 0, 4990, 5000 }),
            Absolute = true
        };
        public static LinguisticVariable around15000 = new LinguisticVariable
        {
            Name = "Around 15000",
            MembershipFunction = new TriangularFunction(new List<double> { 14000, 15000, 16000 }),
            Absolute = true
        };
        public static LinguisticVariable around25000 = new LinguisticVariable
        {
            Name = "Around 25000",
            MembershipFunction = new TriangularFunction(new List<double> { 24000, 25000, 26000 }),
            Absolute = true
        };
        public static LinguisticVariable moreThan35000 = new LinguisticVariable
        {
            Name = "More than 35000",
            MembershipFunction = new TrapezoidFunction(new List<double> { 35000, 35010, 41000, 41000 }),
            Absolute = true
        };


        #endregion
        public static ObservableCollection<LinguisticVariable> getAllQuantifiers()
        {
            return new ObservableCollection<LinguisticVariable>
            {
                no,
                lessThanThird,
                aroundHalf,
                aroundThreeQuaters,
                majority,
                almostAll,
                lessThan5000,
                around15000,
                around25000,
                moreThan35000
            };
        }
    }
}
