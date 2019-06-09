using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Membership
{
    public class AndFunction : ICompoundMembershipFunction
    {
        public IMembershipFunction Function1 { get; set; }
        public IMembershipFunction Function2 { get; set; }

        public AndFunction(IMembershipFunction one, IMembershipFunction two)
        {
            Function1 = one;
            Function2 = two;
        }

        public double GetMembership(double x)
        {
            return Math.Min(Function1.GetMembership(x), Function2.GetMembership(x));
        }

        public List<IMembershipFunction> GetAllFunctions()
        {
            return Function1.GetAllFunctions().Concat(Function2.GetAllFunctions()).ToList();
        }
    }
}
