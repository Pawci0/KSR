using System.Collections.Generic;

namespace Zad2.Membership
{
    public class DiscreteFunction : IMembershipFunction
    {
        public DiscreteFunction(List<double> parameters)
        {
            Parameters = parameters;
        }

        public List<double> Parameters { get; set; }

        public double GetMembership(double x)
        {
            return Parameters[(int)x];
        }
    }
}
