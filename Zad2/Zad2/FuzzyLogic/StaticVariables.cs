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
            MembershipFunction = new TrapezoidFunction(),
            MembershipFunctionParameters = new List<double> { 8, 18 }
        };
        public static LinguisticVariable ageYoungAdult = new LinguisticVariable
        {
            Name = "Young Adult",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(),
            MembershipFunctionParameters = new List<double> { 19, 30 }
        };
        public static LinguisticVariable ageAdult = new LinguisticVariable
        {
            Name = "Adult",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(),
            MembershipFunctionParameters = new List<double> { 31, 50 }
        };
        public static LinguisticVariable ageOld = new LinguisticVariable
        {
            Name = "Old",
            MemberToExtract = "Age",
            MembershipFunction = new TrapezoidFunction(),
            MembershipFunctionParameters = new List<double> { 51, 90 }
        };
        #endregion
    }
}
