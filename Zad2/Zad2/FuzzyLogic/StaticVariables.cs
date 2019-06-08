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
            Extractor = e => new TrapezoidFunction(new List<double> { 8, 8, 17, 20 }).GetMembership(e.Age)
        };
        public static LinguisticVariable ageYoungAdult = new LinguisticVariable
        {
            Name = "Young Adult",
            MemberToExtract = "Age",
            Extractor = e => new TrapezoidFunction(new List<double> { 19, 23, 27, 30 }).GetMembership(e.Age)
        };
        public static LinguisticVariable ageAdult = new LinguisticVariable
        {
            Name = "Adult",
            MemberToExtract = "Age",
            Extractor = e => new TrapezoidFunction(new List<double> { 31, 35, 45, 50 }).GetMembership(e.Age)
        };
        public static LinguisticVariable ageOld = new LinguisticVariable
        {
            Name = "Old",
            MemberToExtract = "Age",
            Extractor = e => new TrapezoidFunction(new List<double> { 51, 60, 90, 90 }).GetMembership(e.Age)
        };
        #endregion
        #region weight
        public static LinguisticVariable weightLight = new LinguisticVariable
        {
            Name = "Light",
            MemberToExtract = "BodyweightKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 40, 40, 60, 70 }).GetMembership(e.Weight)
        };
        public static LinguisticVariable weightRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "BodyweightKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 71, 80, 100, 110 }).GetMembership(e.Weight)
        };
        public static LinguisticVariable weightHeavy = new LinguisticVariable
        {
            Name = "Heavy",
            MemberToExtract = "BodyweightKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 111, 130, 210, 210 }).GetMembership(e.Weight)
        };
        #endregion
        #region Best3SquatKg
        public static LinguisticVariable squatLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 70 }).GetMembership(e.Squat)
        };
        public static LinguisticVariable squatRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 71, 100, 150, 200 }).GetMembership(e.Squat)
        };
        public static LinguisticVariable squatHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 201, 250, 300, 350 }).GetMembership(e.Squat)
        };
        public static LinguisticVariable squatVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 351, 400, 520, 520 }).GetMembership(e.Squat)
        };
        #endregion
        #region Best3BenchKg
        public static LinguisticVariable benchLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 70 }).GetMembership(e.Bench)
        };
        public static LinguisticVariable benchRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 71, 100, 150, 200 }).GetMembership(e.Bench)
        };
        public static LinguisticVariable benchHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 201, 220, 280, 300 }).GetMembership(e.Bench)
        };
        public static LinguisticVariable benchVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 301, 350, 420, 420 }).GetMembership(e.Bench)
        };
        #endregion
        #region Best3DeadliftKg
        public static LinguisticVariable deadliftLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 70 }).GetMembership(e.Deadlift)
        };
        public static LinguisticVariable deadliftRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 71, 100, 150, 200 }).GetMembership(e.Deadlift)
        };
        public static LinguisticVariable deadliftHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 201, 220, 280, 300 }).GetMembership(e.Deadlift)
        };
        public static LinguisticVariable deadliftVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 301, 350, 440, 440 }).GetMembership(e.Deadlift)
        };
        #endregion
        #region Total
        public static LinguisticVariable totalLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 60, 100, 200, 300 }).GetMembership(e.TotalKg)
        };
        public static LinguisticVariable totalRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 301, 350, 450, 500 }).GetMembership(e.TotalKg)
        };
        public static LinguisticVariable totalHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 601, 700, 800, 900 }).GetMembership(e.TotalKg)
        };
        public static LinguisticVariable totalVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 901, 1000, 1300, 1300 }).GetMembership(e.TotalKg)
        };
        #endregion
        #region Place
        public static LinguisticVariable placeVeryLow = new LinguisticVariable
        {
            Name = "Very Low",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 120, 120, 70, 50 }).GetMembership(e.Place)
        };
        public static LinguisticVariable placeLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 51, 40, 25, 20 }).GetMembership(e.Place)
        };
        public static LinguisticVariable placeAlmost = new LinguisticVariable
        {
            Name = "Almost There",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 19, 13, 4, 4 }).GetMembership(e.Place)
        };
        public static LinguisticVariable placeHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 3, 2, 1, 1 }).GetMembership(e.Place)
        };
        #endregion
        #region Wilks
        public static LinguisticVariable wilksLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 150 }).GetMembership(e.Wilks)
        };
        public static LinguisticVariable wilksRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 151, 200, 250, 300 }).GetMembership(e.Wilks)
        };
        public static LinguisticVariable wilksHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 301, 350, 450, 500 }).GetMembership(e.Wilks)
        };
        public static LinguisticVariable wilksVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 501, 600, 750, 750 }).GetMembership(e.Wilks)
        };
        #endregion
        #region McCulloch
        public static LinguisticVariable mcCullochLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 150 }).GetMembership(e.McCulloch)
        };
        public static LinguisticVariable mcCullochRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 151, 200, 250, 300 }).GetMembership(e.McCulloch)
        };
        public static LinguisticVariable mcCullochHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 301, 350, 450, 500 }).GetMembership(e.McCulloch)
        };
        public static LinguisticVariable mcCullochVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 501, 600, 750, 750 }).GetMembership(e.McCulloch)
        };
        #endregion
        #region Glossbrenner
        public static LinguisticVariable glossbrennerLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 150 }).GetMembership(e.Glossbrenner)
        };
        public static LinguisticVariable glossbrennerRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 151, 200, 250, 300 }).GetMembership(e.Glossbrenner)
        };
        public static LinguisticVariable glossbrennerHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 301, 350, 450, 500 }).GetMembership(e.Glossbrenner)
        };
        public static LinguisticVariable glossbrennerVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 501, 600, 750, 750 }).GetMembership(e.Glossbrenner)
        };
        #endregion
        #region IPFPoints
        public static LinguisticVariable ipfLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 150 }).GetMembership(e.IPFPoints)
        };
        public static LinguisticVariable ipfRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 151, 200, 300, 400 }).GetMembership(e.IPFPoints)
        };
        public static LinguisticVariable ipfHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 401, 500, 600, 700 }).GetMembership(e.IPFPoints)
        };
        public static LinguisticVariable ipfVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 701, 800, 1000, 1000 }).GetMembership(e.IPFPoints)
        };
        #endregion

        #region Gender
        public static LinguisticVariable genderMale = new LinguisticVariable
        {
            Name = "Male",
            MemberToExtract = "Sex",
            MembershipFunction = new DiscreteFunction(new List<double> { 1, 0 }),
            Extractor = (e) => new DiscreteFunction(new List<double> { 1, 0 }).GetMembership((int)e.Sex)
        };
        public static LinguisticVariable genderFemale = new LinguisticVariable
        {
            Name = "Female",
            MemberToExtract = "Sex",
            MembershipFunction = new DiscreteFunction(new List<double> { 0, 1 }),
            Extractor = (e) => new DiscreteFunction(new List<double> { 0, 1 }).GetMembership((int)e.Sex)
        };
        #endregion
        #region Tested
        public static LinguisticVariable testedNo = new LinguisticVariable
        {
            Name = "No",
            MemberToExtract = "Tested",
            Extractor = (e) => new DiscreteFunction(new List<double> { 0, 1 }).GetMembership((int)e.Tested)
        };
        public static LinguisticVariable testedYes = new LinguisticVariable
        {
            Name = "Yes",
            MemberToExtract = "Tested",
            Extractor = (e) => new DiscreteFunction(new List<double> { 1, 0 }).GetMembership((int)e.Tested)
        };
        #endregion

        #region Quantizers
        //relative
        public static LinguisticVariable few = new LinguisticVariable
        {
            Name = "Few",
            MembershipFunction = new TriangularFunction(new List<double> { 0, 0.15, 0.3 }),
            Absolute = false
        };
        public static LinguisticVariable aroundHalf = new LinguisticVariable
        {
            Name = "Around half",
            MembershipFunction = new TriangularFunction(new List<double> { 0.4, 0.5, 0.6 }),
            Absolute = false
        };
        public static LinguisticVariable almostAll = new LinguisticVariable
        {
            Name = "Almost all",
            MembershipFunction = new TrapezoidFunction(new List<double> { 0.8, 0.9, 1, 1 }),
            Absolute = false
        };

        //absolute
        public static LinguisticVariable around3000 = new LinguisticVariable
        {
            Name = "Around 3000",
            MembershipFunction = new TriangularFunction(new List<double> { 2500, 3000, 3500}),
            Absolute = true
        };
        public static LinguisticVariable moreThan10000 = new LinguisticVariable
        {
            Name = "Much more than 10000",
            MembershipFunction = new TrapezoidFunction(new List<double> { 10000, 15000, 45000, 45000 }),
            Absolute = true
        };
        #endregion
    }
}
