using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    public static class StaticVariables
    {
        #region Age
        public static LinguisticVariable ageYoung = new LinguisticVariable
        {
            Name = "Young",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(new List<double> { 8, 8, 14, 18 })
        };
        public static LinguisticVariable ageYoungAdult = new LinguisticVariable
        {
            Name = "Young Adult",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(new List<double> { 19, 23, 27, 30 })
        };
        public static LinguisticVariable ageAdult = new LinguisticVariable
        {
            Name = "Adult",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(new List<double> { 31, 35, 45, 50 })
        };
        public static LinguisticVariable ageOld = new LinguisticVariable
        {
            Name = "Old",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(new List<double> { 51, 60, 90, 90 })
        };
        #endregion
        #region weight
        public static LinguisticVariable weightLight = new LinguisticVariable
        {
            Name = "Light",
            MemberToExtract = "BodyweightKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 40, 40, 60, 70 })
        };
        public static LinguisticVariable weightRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "BodyweightKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 71, 80, 100, 110 })
        };
        public static LinguisticVariable weightHeavy = new LinguisticVariable
        {
            Name = "Heavy",
            MemberToExtract = "BodyweightKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 111, 130, 210, 210 })
        };
        #endregion
        #region Best3SquatKg
        public static LinguisticVariable squatLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3SquatKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 20, 20, 60, 70 })
        };
        public static LinguisticVariable squatRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3SquatKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 71, 100, 150, 200 })
        };
        public static LinguisticVariable squatHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3SquatKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 201, 250, 300, 350 })
        };
        public static LinguisticVariable squatVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3SquatKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 351, 400, 520, 520 })
        };
        #endregion
        #region Best3BenchKg
        public static LinguisticVariable benchLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3BenchKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 20, 20, 60, 70 })
        };
        public static LinguisticVariable benchRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3BenchKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 71, 100, 150, 200 })
        };
        public static LinguisticVariable benchHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3BenchKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 201, 220, 280, 300 })
        };
        public static LinguisticVariable benchVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3BenchKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 301, 350, 420, 420 })
        };
        #endregion
        #region Best3DeadliftKg
        public static LinguisticVariable deadliftLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3DeadliftKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 20, 20, 60, 70 })
        };
        public static LinguisticVariable deadliftRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3DeadliftKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 71, 100, 150, 200 })
        };
        public static LinguisticVariable deadliftHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3DeadliftKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 201, 220, 280, 300 })
        };
        public static LinguisticVariable deadliftVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3DeadliftKg",
            MembershipFunction = new TrapezoidFunction(new List<double> { 301, 350, 440, 440 })
        };
        #endregion
        #region Total
        public static LinguisticVariable totalLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Total",
            MembershipFunction = new TrapezoidFunction(new List<double> { 60, 100, 200, 300 })
        };
        public static LinguisticVariable totalRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Total",
            MembershipFunction = new TrapezoidFunction(new List<double> { 301, 350, 450, 500 })
        };
        public static LinguisticVariable totalHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Total",
            MembershipFunction = new TrapezoidFunction(new List<double> { 601, 700, 800, 900 })
        };
        public static LinguisticVariable totalVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Total",
            MembershipFunction = new TrapezoidFunction(new List<double> { 901, 1000, 1300, 1300 })
        };
        #endregion
    }
}
