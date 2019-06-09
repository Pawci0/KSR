using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Membership
{
    public class MultiplyDecorator : IMembershipDecorator
    {
        public IMembershipFunction Function1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMembershipFunction Function2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        ///to w zasadzie problem tego, ze w imembershipfunction niepotrzebnie jest to property
        public List<double> Parameters { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public MultiplyDecorator(IMembershipDecorator one, IMembershipDecorator two)
        {
            Function1 = one;
            Function2 = two;
        }

        public double GetMembership(double x)
        {
            return Math.Min(Function1.GetMembership(x), Function2.GetMembership(x));
        }
    }
}
