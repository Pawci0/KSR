using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.Membership;

namespace Zad2.FuzzyLogic
{
    public class LinguisticVariable
    {
        public string Name { get; set; }
        public IMembershipFunction MembershipFunction { get; set; }
        public List<double> MembershipFunctionParameters { get; set; }
        public string MemberToExtract { get; set; }

    }
}
