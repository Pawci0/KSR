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
    }
}
