using System.Collections.Generic;
using System.Linq;

namespace Zad2.Membership
{
    public class DiscreteFunction : IMembershipFunction
    {
        public DiscreteFunction(List<double> parameters)
        {
            Parameters = parameters;
        }

        public List<double> Parameters { get; set; }

        public double Cardinality()
        {
            return Parameters.Sum();
        }

        public List<IMembershipFunction> GetAllFunctions()
        {
            return new List<IMembershipFunction> { this };
        }

        public double GetMembership(double x)
        {
            return Parameters[(int)x];
        }
    }
}
