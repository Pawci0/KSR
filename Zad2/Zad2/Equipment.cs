using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Zad2.DataModel.Enums
{
    public enum Equipment
    {
        Wraps,
        [Display(Name = "Mulit-ply")]
        Multi_ply,
        Raw,
        [Display(Name = "Single-ply")]
        Single_ply
    }
}
