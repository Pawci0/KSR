﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Membership
{
    public interface IMembershipDecorator : IMembershipFunction
    {
        IMembershipFunction Function1 { get; set; }
        IMembershipFunction Function2 { get; set; }
        new double GetMembership(double x);
    }
}
