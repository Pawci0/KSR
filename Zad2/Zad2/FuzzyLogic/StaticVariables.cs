using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Extractor = e => new TrapezoidFunction(new List<double> { 8, 8, 17, 20 }).GetMembership(e.Age),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 8, 8, 17, 20 }),
                FieldExtractor = (e) => e.Age
            }
        };
        public static LinguisticVariable ageYoungAdult = new LinguisticVariable
        {
            Name = "Young Adult",
            MemberToExtract = "Age",
            Extractor = e => new TrapezoidFunction(new List<double> { 19, 23, 27, 31 }).GetMembership(e.Age),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 19, 23, 27, 31 }),
                FieldExtractor = (e) => e.Age
            }
        };
        public static LinguisticVariable ageAdult = new LinguisticVariable
        {
            Name = "Adult",
            MemberToExtract = "Age",
            Extractor = e => new TrapezoidFunction(new List<double> { 30, 35, 45, 51 }).GetMembership(e.Age),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 30, 35, 45, 51 }),
                FieldExtractor = (e) => e.Age
            }
        };
        public static LinguisticVariable ageOld = new LinguisticVariable
        {
            Name = "Old",
            MemberToExtract = "Age",
            Extractor = e => new TrapezoidFunction(new List<double> { 50, 60, 90, 90 }).GetMembership(e.Age),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 50, 60, 90, 90 }),
                FieldExtractor = (e) => e.Age
            }
        };
        #endregion
        #region weight
        public static LinguisticVariable weightLight = new LinguisticVariable
        {
            Name = "Light",
            MemberToExtract = "BodyweightKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 40, 40, 60, 71 }).GetMembership(e.Weight),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 40, 40, 60, 71 }),
                FieldExtractor = (e) => e.Weight
            }
        };
        public static LinguisticVariable weightRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "BodyweightKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 70, 80, 100, 111 }).GetMembership(e.Weight),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 70, 80, 100, 111 }),
                FieldExtractor = (e) => e.Weight
            }
        };
        public static LinguisticVariable weightHeavy = new LinguisticVariable
        {
            Name = "Heavy",
            MemberToExtract = "BodyweightKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 110, 130, 210, 210 }).GetMembership(e.Weight),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 110, 130, 210, 210 }),
                FieldExtractor = (e) => e.Weight
            }
        };
        #endregion
        #region Best3SquatKg
        public static LinguisticVariable squatLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 75 }).GetMembership(e.Squat),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 20, 20, 60, 75 }),
                FieldExtractor = (e) => e.Squat
            }
        };
        public static LinguisticVariable squatRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 70, 100, 150, 210 }).GetMembership(e.Squat),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 70, 100, 150, 210 }),
                FieldExtractor = (e) => e.Squat
            }
        };
        public static LinguisticVariable squatHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 200, 250, 300, 360}).GetMembership(e.Squat),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 200, 250, 300, 360 }),
                FieldExtractor = (e) => e.Squat
            }
        };
        public static LinguisticVariable squatVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3SquatKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 350, 400, 520, 520 }).GetMembership(e.Squat),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 350, 400, 520, 520 }),
                FieldExtractor = (e) => e.Squat
            }
        };
        #endregion
        #region Best3BenchKg
        public static LinguisticVariable benchLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 75 }).GetMembership(e.Bench),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 20, 20, 60, 75 }),
                FieldExtractor = (e) => e.Bench
            }
        };
        public static LinguisticVariable benchRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 70, 100, 150, 210 }).GetMembership(e.Bench),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 70, 100, 150, 210 }),
                FieldExtractor = (e) => e.Bench
            }
        };
        public static LinguisticVariable benchHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 200, 220, 280, 310 }).GetMembership(e.Bench),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 200, 220, 280, 310 }),
                FieldExtractor = (e) => e.Bench
            }
        };
        public static LinguisticVariable benchVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3BenchKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 300, 350, 420, 420 }).GetMembership(e.Bench),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 300, 350, 420, 420 }),
                FieldExtractor = (e) => e.Bench
            }
        };
        #endregion
        #region Best3DeadliftKg
        public static LinguisticVariable deadliftLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 20, 20, 60, 75 }).GetMembership(e.Deadlift),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 20, 20, 60, 75 }),
                FieldExtractor = (e) => e.Deadlift
            }
        };
        public static LinguisticVariable deadliftRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 70, 100, 150, 210 }).GetMembership(e.Deadlift),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 70, 100, 150, 210 }),
                FieldExtractor = (e) => e.Deadlift
            }
        };
        public static LinguisticVariable deadliftHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 200, 220, 280, 310 }).GetMembership(e.Deadlift),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 200, 220, 280, 310 }),
                FieldExtractor = (e) => e.Deadlift
            }
        };
        public static LinguisticVariable deadliftVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Best3DeadliftKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 300, 350, 440, 440 }).GetMembership(e.Deadlift),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 300, 350, 440, 440 }),
                FieldExtractor = (e) => e.Deadlift
            }
        };
        #endregion
        #region Total
        public static LinguisticVariable totalLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 60, 100, 200, 310 }).GetMembership(e.TotalKg),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 60, 100, 200, 310 }),
                FieldExtractor = (e) => e.TotalKg
            }
        };
        public static LinguisticVariable totalRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 300, 350, 450, 610 }).GetMembership(e.TotalKg),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 300, 350, 450, 610 }),
                FieldExtractor = (e) => e.TotalKg
            }
        };
        public static LinguisticVariable totalHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 600, 700, 800, 910 }).GetMembership(e.TotalKg),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 600, 700, 800, 910 }),
                FieldExtractor = (e) => e.TotalKg
            }
        };
        public static LinguisticVariable totalVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "TotalKg",
            Extractor = e => new TrapezoidFunction(new List<double> { 900, 1000, 1300, 1300 }).GetMembership(e.TotalKg),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 900, 1000, 1300, 1300 }),
                FieldExtractor = (e) => e.TotalKg
            }
        };
        #endregion
        #region Place
        public static LinguisticVariable placeVeryLow = new LinguisticVariable
        {
            Name = "Very Low",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 120, 120, 70, 55 }).GetMembership(e.Place),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 55, 70, 120, 120 }),
                FieldExtractor = (e) => e.Place
            }
        };
        public static LinguisticVariable placeLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 50, 40, 25, 15 }).GetMembership(e.Place),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 15, 25, 40, 50 }),
                FieldExtractor = (e) => e.Place
            }
        };
        public static LinguisticVariable placeAlmost = new LinguisticVariable
        {
            Name = "Almost There",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 20, 13, 4, 3 }).GetMembership(e.Place),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 3, 4, 13, 20 }),
                FieldExtractor = (e) => e.Place
            }
        };
        public static LinguisticVariable placeHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Place",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 4, 3, 1, 1 }).GetMembership(e.Place),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 1, 1, 3, 4 }),
                FieldExtractor = (e) => e.Place
            }
        };
        #endregion
        #region Wilks
        public static LinguisticVariable wilksLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }).GetMembership(e.Wilks),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }),
                FieldExtractor = (e) => e.Wilks
            }
        };
        public static LinguisticVariable wilksRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 150, 200, 250, 310 }).GetMembership(e.Wilks),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 150, 200, 250, 310 }),
                FieldExtractor = (e) => e.Wilks
            }
        };
        public static LinguisticVariable wilksHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 300, 350, 450, 510 }).GetMembership(e.Wilks),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 300, 350, 450, 510 }),
                FieldExtractor = (e) => e.Wilks
            }
        };
        public static LinguisticVariable wilksVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Wilks",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 500, 600, 750, 750 }).GetMembership(e.Wilks),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 500, 600, 750, 750 }),
                FieldExtractor = (e) => e.Wilks
            }
        };
        #endregion
        #region McCulloch
        public static LinguisticVariable mcCullochLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }).GetMembership(e.McCulloch),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }),
                FieldExtractor = (e) => e.McCulloch
            }
        };
        public static LinguisticVariable mcCullochRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 150, 200, 250, 310 }).GetMembership(e.McCulloch),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 150, 200, 250, 310 }),
                FieldExtractor = (e) => e.McCulloch
            }
        };
        public static LinguisticVariable mcCullochHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 300, 350, 450, 510 }).GetMembership(e.McCulloch),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 300, 350, 450, 510 }),
                FieldExtractor = (e) => e.McCulloch
            }
        };
        public static LinguisticVariable mcCullochVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "McCulloch",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 500, 600, 750, 750 }).GetMembership(e.McCulloch),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 500, 600, 750, 750 }),
                FieldExtractor = (e) => e.McCulloch
            }
        };
        #endregion
        #region Glossbrenner
        public static LinguisticVariable glossbrennerLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }).GetMembership(e.Glossbrenner),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }),
                FieldExtractor = (e) => e.Glossbrenner
            }
        };
        public static LinguisticVariable glossbrennerRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 150, 200, 250, 310 }).GetMembership(e.Glossbrenner),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 150, 200, 250, 310 }),
                FieldExtractor = (e) => e.Glossbrenner
            }
        };
        public static LinguisticVariable glossbrennerHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 300, 350, 450, 510 }).GetMembership(e.Glossbrenner),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 300, 350, 450, 510 }),
                FieldExtractor = (e) => e.Glossbrenner
            }
        };
        public static LinguisticVariable glossbrennerVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "Glossbrenner",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 500, 600, 750, 750 }).GetMembership(e.Glossbrenner),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 500, 600, 750, 750 }),
                FieldExtractor = (e) => e.Glossbrenner
            }
        };
        #endregion
        #region IPFPoints
        public static LinguisticVariable ipfLow = new LinguisticVariable
        {
            Name = "Low",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }).GetMembership(e.IPFPoints),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 75, 100, 120, 160 }),
                FieldExtractor = (e) => e.IPFPoints
            }
        };
        public static LinguisticVariable ipfRegular = new LinguisticVariable
        {
            Name = "Regular",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 150, 200, 300, 410 }).GetMembership(e.IPFPoints),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 150, 200, 300, 410 }),
                FieldExtractor = (e) => e.IPFPoints
            }
        };
        public static LinguisticVariable ipfHigh = new LinguisticVariable
        {
            Name = "High",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 400, 500, 600, 710 }).GetMembership(e.IPFPoints),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 400, 500, 600, 710 }),
                FieldExtractor = (e) => e.IPFPoints
            }
        };
        public static LinguisticVariable ipfVeryHigh = new LinguisticVariable
        {
            Name = "Very High",
            MemberToExtract = "IPFPoints",
            Extractor = (e) => new TrapezoidFunction(new List<double> { 700, 800, 1000, 1000 }).GetMembership(e.IPFPoints),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new TrapezoidFunction(new List<double> { 700, 800, 1000, 1000 }),
                FieldExtractor = (e) => e.IPFPoints
            }
        };
        #endregion

        #region Gender
        public static LinguisticVariable genderMale = new LinguisticVariable
        {
            Name = "Male",
            MemberToExtract = "Sex",
            Extractor = (e) => new DiscreteFunction(new List<double> { 1, 0 }).GetMembership((int)e.Sex),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new DiscreteFunction(new List<double> { 1, 0 }),
                FieldExtractor = (e) => (int)e.Sex
            }
        };
        public static LinguisticVariable genderFemale = new LinguisticVariable
        {
            Name = "Female",
            MemberToExtract = "Sex",
            Extractor = (e) => new DiscreteFunction(new List<double> { 0, 1 }).GetMembership((int)e.Sex),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new DiscreteFunction(new List<double> { 0, 1 }),
                FieldExtractor = (e) => (int)e.Sex
            }
        };
        #endregion
        #region Tested
        public static LinguisticVariable testedNo = new LinguisticVariable
        {
            Name = "No",
            MemberToExtract = "Tested",
            Extractor = (e) => new DiscreteFunction(new List<double> { 0, 1 }).GetMembership((int)e.Tested),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new DiscreteFunction(new List<double> { 0, 1 }),
                FieldExtractor = (e) => (int)e.Tested
            }
        };
        public static LinguisticVariable testedYes = new LinguisticVariable
        {
            Name = "Yes",
            MemberToExtract = "Tested",
            Extractor = (e) => new DiscreteFunction(new List<double> { 1, 0 }).GetMembership((int)e.Tested),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new DiscreteFunction(new List<double> { 1, 0 }),
                FieldExtractor = (e) => (int)e.Tested
            }
        };
        #endregion

        public static LinguisticVariable none = new LinguisticVariable
        {
            Name = "--",
            MemberToExtract = "--",
            Extractor = (e) => new ConstantFunction().GetMembership(0.0),
            FuzzySet = new FuzzySet
            {
                MembershipFunction = new ConstantFunction(),
                FieldExtractor = (e) => 0.0
            }
        };

        public static ObservableCollection<LinguisticVariable> getAllVariables()
        {
            return new ObservableCollection<LinguisticVariable>
            {
                ageYoung, ageYoungAdult, ageAdult, ageOld,
                weightLight, weightRegular, weightHeavy,
                squatLow, squatRegular, squatHigh, squatVeryHigh,
                benchLow, benchRegular, benchHigh, benchVeryHigh,
                deadliftLow, deadliftRegular, deadliftHigh, deadliftVeryHigh,
                totalLow, totalRegular, totalHigh, totalVeryHigh,
                placeVeryLow, placeLow, placeAlmost, placeHigh,
                wilksLow, wilksRegular, wilksHigh, wilksVeryHigh,
                mcCullochLow, mcCullochRegular, mcCullochHigh, mcCullochVeryHigh,
                glossbrennerLow, glossbrennerRegular, glossbrennerHigh, glossbrennerVeryHigh,
                ipfLow, ipfRegular, ipfHigh, ipfVeryHigh,
                genderMale, genderFemale,
                testedNo, testedYes, none
            };
        }
    }
}
