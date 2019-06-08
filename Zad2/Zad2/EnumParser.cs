using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.DataModel.Enums
{
    static class EnumParser
    {
        public static void Parse(string value, out MeetName ret)
        {
            if (value.Equals("Collegiate Nationals"))
            {
                ret = MeetName.Collegiate_Nationals;
            }
            else if (value.Equals("European Championships"))
            {
                ret = MeetName.European_Championships;
            }
            else if (value.Equals("Nationals"))
            {
                ret = MeetName.Nationals;
            }
            else if (value.Equals("Raw Nationals"))
            {
                ret = MeetName.Raw_Nationals;
            }
            else if (value.Equals("Russian Powerlifting Championships"))
            {
                ret = MeetName.Russian_Powerlifting_Championships;
            }
            else if (value.Equals("World Championships"))
            {
                ret = MeetName.World_Championships;
            }
            else if (value.Equals("World Cup"))
            {
                ret = MeetName.World_Cup;
            }
            else if (value.Equals("World Masters Powerlifting Championships"))
            {
                ret = MeetName.World_Masters_Powerlifting_Championships;
            }
            else
            {
                ret = MeetName.World_Powerlifting_Championships;
            }
        }

        public static void Parse(string value, out Equipment ret)
        {
            if (value.Equals("Multi-ply"))
            {
                ret = Equipment.Multi_ply;
            }
            else if (value.Equals("Raw"))
            {
                ret = Equipment.Raw;
            }
            else if (value.Equals("Single-ply"))
            {
                ret = Equipment.Single_ply;
            }
            else
            {
                ret = Equipment.Wraps;
            }
        }
    }
}
