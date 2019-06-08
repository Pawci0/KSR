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
            extractor = e => new TrapezoidFunction(new List<double> { 8, 8, 14, 18 }).GetMembership(e.Age)
        };
        public static LinguisticVariable ageYoungAdult = new LinguisticVariable
        {
            Name = "Young Adult",
            MemberToExtract = "Age",
            extractor = e => new TrapezoidFunction(new List<double> { 19, 23, 27, 30 }).GetMembership(e.Age)
        };
        public static LinguisticVariable ageAdult = new LinguisticVariable
        {
            Name = "Adult",
            MemberToExtract = "Age",
            extractor = e => new TrapezoidFunction(new List<double> { 31, 35, 45, 50 }).GetMembership(e.Age)
        };
        public static LinguisticVariable ageOld = new LinguisticVariable
        {
            Name = "Old",
            MemberToExtract = "Age",
            extractor = e => new TrapezoidFunction(new List<double> { 51, 60, 90, 90 }).GetMembership(e.Age)
        };
        #endregion
        #region weight
        public static LinguisticVariable weightLight = new LinguisticVariable
        {
            Name = "Light",
            MemberToExtract = "BodyweightKg",
            extractor = e => new TrapezoidFunction(new List<double> { 40, 40, 60, 70 }).GetMembership(e.Weight)
        };
        public static LinguisticVariable weightRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "BodyweightKg",
            extractor = e => new TrapezoidFunction(new List<double> { 71, 80, 100, 110 }).GetMembership(e.Weight)
        };
        public static LinguisticVariable weightHeavy = new LinguisticVariable
        {
            Name = "Heavy",
            MemberToExtract = "BodyweightKg",
            extractor = e => new TrapezoidFunction(new List<double> { 111, 130, 210, 210 }).GetMembership(e.Weight)
        };
        #endregion
        #region Best3SquatKg
        public static LinguisticVariable squatLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3SquatKg",
            extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 70 }).GetMembership(e.Squat)
        };
        public static LinguisticVariable squatRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3SquatKg",
            extractor = e => new TrapezoidFunction(new List<double> { 71, 100, 150, 200 }).GetMembership(e.Squat)
        };
        public static LinguisticVariable squatHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3SquatKg",
            extractor = e => new TrapezoidFunction(new List<double> { 201, 250, 300, 350 }).GetMembership(e.Squat)
        };
        public static LinguisticVariable squatVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3SquatKg",
            extractor = e => new TrapezoidFunction(new List<double> { 351, 400, 520, 520 }).GetMembership(e.Squat)
        };
        #endregion
        #region Best3BenchKg
        public static LinguisticVariable benchLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3BenchKg",
            extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 70 }).GetMembership(e.Bench)
        };
        public static LinguisticVariable benchRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3BenchKg",
            extractor = e => new TrapezoidFunction(new List<double> { 71, 100, 150, 200 }).GetMembership(e.Bench)
        };
        public static LinguisticVariable benchHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3BenchKg",
            extractor = e => new TrapezoidFunction(new List<double> { 201, 220, 280, 300 }).GetMembership(e.Bench)
        };
        public static LinguisticVariable benchVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3BenchKg",
            extractor = e => new TrapezoidFunction(new List<double> { 301, 350, 420, 420 }).GetMembership(e.Bench)
        };
        #endregion
        #region Best3DeadliftKg
        public static LinguisticVariable deadliftLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3DeadliftKg",
            extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 70 }).GetMembership(e.Deadlift)
        };
        public static LinguisticVariable deadliftRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3DeadliftKg",
            extractor = e => new TrapezoidFunction(new List<double> { 71, 100, 150, 200 }).GetMembership(e.Deadlift)
        };
        public static LinguisticVariable deadliftHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3DeadliftKg",
            extractor = e => new TrapezoidFunction(new List<double> { 201, 220, 280, 300 }).GetMembership(e.Deadlift)
        };
        public static LinguisticVariable deadliftVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3DeadliftKg",
            extractor = e => new TrapezoidFunction(new List<double> { 301, 350, 440, 440 }).GetMembership(e.Deadlift)
        };
        #endregion
        #region Total
        public static LinguisticVariable totalLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Total",
            extractor = e => new TrapezoidFunction(new List<double> { 60, 100, 200, 300 }).GetMembership(e.Total)
        };
        public static LinguisticVariable totalRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Total",
            extractor = e => new TrapezoidFunction(new List<double> { 301, 350, 450, 500 }).GetMembership(e.Total)
        };
        public static LinguisticVariable totalHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Total",
            extractor = e => new TrapezoidFunction(new List<double> { 601, 700, 800, 900 }).GetMembership(e.Total)
        };
        public static LinguisticVariable totalVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Total",
            extractor = e => new TrapezoidFunction(new List<double> { 901, 1000, 1300, 1300 }).GetMembership(e.Total)
        };
        #endregion
        #region Place
        public static LinguisticVariable placeVeryLow = new LinguisticVariable
        {
            Name = "Very Low",
            MemberToExtract = "Place",
            MembershipFunction = new TrapezoidFunction(new List<double> { 120, 120, 70, 50 })
        };
        public static LinguisticVariable placeLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Place",
            MembershipFunction = new TrapezoidFunction(new List<double> { 51, 40, 25, 20 })
        };
        public static LinguisticVariable placeAlmost = new LinguisticVariable
        {
            Name = "Almost There",
            MemberToExtract = "Place",
            MembershipFunction = new TrapezoidFunction(new List<double> { 19, 13, 4, 4 })
        };
        public static LinguisticVariable placeHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Place",
            MembershipFunction = new TrapezoidFunction(new List<double> { 3, 2, 1, 1 })
        };
        #endregion
        #region Wilks
        public static LinguisticVariable wilksLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Wilks",
            MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 150 })
        };
        public static LinguisticVariable wilksRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Wilks",
            MembershipFunction = new TrapezoidFunction(new List<double> { 151, 200, 250, 300 })
        };
        public static LinguisticVariable wilksHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Wilks",
            MembershipFunction = new TrapezoidFunction(new List<double> { 301, 350, 450, 500 })
        };
        public static LinguisticVariable wilksVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Wilks",
            MembershipFunction = new TrapezoidFunction(new List<double> { 501, 600, 750, 750 })
        };
        #endregion
        #region McCulloch
        public static LinguisticVariable mcCullochLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "McCulloch",
            MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 150 })
        };
        public static LinguisticVariable mcCullochRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "McCulloch",
            MembershipFunction = new TrapezoidFunction(new List<double> { 151, 200, 250, 300 })
        };
        public static LinguisticVariable mcCullochHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "McCulloch",
            MembershipFunction = new TrapezoidFunction(new List<double> { 301, 350, 450, 500 })
        };
        public static LinguisticVariable mcCullochVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "McCulloch",
            MembershipFunction = new TrapezoidFunction(new List<double> { 501, 600, 750, 750 })
        };
        #endregion
        #region Glossbrenner
        public static LinguisticVariable glossbrennerLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Glossbrenner",
            MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 150 })
        };
        public static LinguisticVariable glossbrennerRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Glossbrenner",
            MembershipFunction = new TrapezoidFunction(new List<double> { 151, 200, 250, 300 })
        };
        public static LinguisticVariable glossbrennerHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Glossbrenner",
            MembershipFunction = new TrapezoidFunction(new List<double> { 301, 350, 450, 500 })
        };
        public static LinguisticVariable glossbrennerVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Glossbrenner",
            MembershipFunction = new TrapezoidFunction(new List<double> { 501, 600, 750, 750 })
        };
        #endregion
        #region IPFPoints
        public static LinguisticVariable ipfLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "IPFPoints",
            MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 150 })
        };
        public static LinguisticVariable ipfRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "IPFPoints",
            MembershipFunction = new TrapezoidFunction(new List<double> { 151, 200, 300, 400 })
        };
        public static LinguisticVariable ipfHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "IPFPoints",
            MembershipFunction = new TrapezoidFunction(new List<double> { 401, 500, 600, 700 })
        };
        public static LinguisticVariable ipfVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "IPFPoints",
            MembershipFunction = new TrapezoidFunction(new List<double> { 701, 800, 1000, 1000 })
        };
        #endregion

        #region Gender
        public static LinguisticVariable genderMale = new LinguisticVariable
        {
            Name = "Male",
            MemberToExtract = "Sex",
            MembershipFunction = new DiscreteFunction(new List<double> { 1, 0 })
        };
        public static LinguisticVariable genderFemale = new LinguisticVariable
        {
            Name = "Female",
            MemberToExtract = "Sex",
            MembershipFunction = new DiscreteFunction(new List<double> { 0, 1 })
        };
        #endregion
        #region Tested
        public static LinguisticVariable testedNo = new LinguisticVariable
        {
            Name = "No",
            MemberToExtract = "Tested",
            MembershipFunction = new DiscreteFunction(new List<double> { 0, 1 })
        };
        public static LinguisticVariable testedYes = new LinguisticVariable
        {
            Name = "Yes",
            MemberToExtract = "Tested",
            MembershipFunction = new DiscreteFunction(new List<double> { 1, 0 })
        };
        #endregion

        #region Quantizers
        public static LinguisticVariable around3000 = new LinguisticVariable
        {
            Name = "Around 3000",
            MembershipFunction = new TriangularFunction(new List<double> { 2500, 3000, 3500})
        };
        public static LinguisticVariable moreThan10000 = new LinguisticVariable
        {
            Name = "Much more than 10000",
            MembershipFunction = new TriangularFunction(new List<double> { 10000, 15000, 45000 })
        };
        #endregion
    }
}
