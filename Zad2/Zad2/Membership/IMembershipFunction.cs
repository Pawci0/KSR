using System.Collections.Generic;

namespace Zad2.Membership
{
    public interface IMembershipFunction
    {
        double GetMembership(double x);
        List<IMembershipFunction> GetAllFunctions();
        List<double> Parameters { get; set; }
        double Cardinality();
    }
}
