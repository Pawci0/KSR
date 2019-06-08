using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.DataModel
{
    [Table(Name = "db")]
    public partial class Entry
    {

        private string _Sex;

        private double _Weight;

        private string _Equipment;

        private double _Age;

        private double _Squat;

        private double _Bench;

        private double _Deadlift;

        private double _TotalKg;

        private int _Place;

        private string _Tested;

        private string _MeetName;

        public Entry()
        {
        }

        [Column(Name = "Sex")]
        private string Sex
        {
            set
            {
                if ((this._Sex != value))
                {
                    this._Sex = value;
                }
            }
        }

        public Enums.Sex GetSex()
        {
            Enums.Sex ret;
            Enum.TryParse(_Sex, out ret);
            return ret;
        }

        [Column(Name = "BodyweightKg")]
        private double Weight
        {
            set
            {
                if ((this._Weight != value))
                {
                    this._Weight = value;
                }
            }
        }

        [Column(Name = "Equipment")]
        private string Equipment
        {
            set
            {
                if ((this._Equipment != value))
                {
                    this._Equipment = value;
                }
            }
        }

        public Enums.Equipment GetEquipment()
        {
            Enums.Equipment ret;
            Enums.EnumParser.Parse(_Equipment, out ret);
            return ret;
        }

        [Column(Name = "Age")]
        private double Age
        {
            set
            {
                if ((this._Age != value))
                {
                    this._Age = value;
                }
            }
        }

        [Column(Name = "Best3SquatKg")]
        private double Squat
        {
            set
            {
                if ((this._Squat != value))
                {
                    this._Squat = value;
                }
            }
        }

        [Column(Name = "Best3BenchKg")]
        private double Bench
        {
            set
            {
                if ((this._Bench != value))
                {
                    this._Bench = value;
                }
            }
        }

        [Column(Name = "Best3DeadliftKg")]
        private double Deadlift
        {
            set
            {
                if ((this._Deadlift != value))
                {
                    this._Deadlift = value;
                }
            }
        }

        [Column(Name = "TotalKg")]
        private double TotalKg
        {
            set
            {
                if ((this._TotalKg != value))
                {
                    this._TotalKg = value;
                }
            }
        }

        [Column(Name = "Place")]
        private int Place
        {
            set
            {
                if ((this._Place != value))
                {
                    this._Place = value;
                }
            }
        }

        [Column(Name = "Tested")]
        private string Tested
        {
            set
            {
                if ((this._Tested != value))
                {
                    this._Tested = value;
                }
            }
        }

        public Enums.Tested GetTested()
        {
            Enums.Tested ret;
            Enum.TryParse(_Tested, out ret);
            return ret;
        }

        [Column(Name = "MeetName")]
        private string MeetName
        {
            set
            {
                if ((this._MeetName != value))
                {
                    this._MeetName = value;
                }
            }
        }

        public Enums.MeetName GetMeetName()
        {
            Enums.MeetName ret;
            Enums.EnumParser.Parse(_MeetName, out ret);
            return ret;
        }
    }
}
