using System;
using System.Collections.Generic;

namespace Zad2.Membership
{
    public class TriangularFunction : IMembershipFunction
    {
        public List<double> Parameters { get => new List<double> { a, b, c };
            set {
                if (value.Count != 3)
                    throw new ArgumentException("invalid amount of arguments");
                a = value[0];
                b = value[1];
                c = value[2];
            }
        }
        private double a, b, c;

        public TriangularFunction(List<double> parameters)
        {
            Parameters = parameters;
        }

        public double GetMembership(double x)
        {
            if (x <= a)
                return 0.0;
            else if (a <= x && x < b)
                return (x - a) / (b - a);
            else if (b == x)
                return 1.0;
            else if (b < x && x <= c)
                return (c - x) / (c - b);
            else
                return 0.0;
        }

        public List<IMembershipFunction> GetAllFunctions()
        {
            return new List<IMembershipFunction> { this };
        }

        public double Cardinality()
        {
            return (c - a) / 2;
        }
    }
}
