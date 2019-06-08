using System.Collections.Generic;

namespace Zad2.Membership
{
    public interface IMembershipFunction
    {
        List<double> Parameters { get; set; }
        double GetMembership(double x);
    }
}
