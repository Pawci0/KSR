﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double GetMembership(double x)
        {
            if (x <= a)
                return 0.0;
            else if (a <= x && x <= b)
                return (x - a) / (b - a);
            else if (b <= x && x <= c)
                return (c - x) / (c - b);
            else
                return 0.0;
        }
    }
}
