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

        private string _sex;

        private double _weight;

        private string _equipment;

        private double _age;

        private double _squat;

        private double _bench;

        private double _deadlift;

        private double _totalKg;

        private int _place;

        private string _tested;

        private string _meetName;

        private Enums.Equipment _equipmentEnum;

        private Enums.Sex _sexEnum;

        private Enums.MeetName _meetNameEnum;

        private Enums.Tested _testedEnum;

        public Entry()
        {
        }

        [Column(Name = "Sex")]
        private string _Sex
        {
            set
            {
                if ((this._sex != value))
                {
                    Enum.TryParse(value, out _sexEnum);
                    this._sex = value;
                }
            }
        }

        public Enums.Sex Sex
        {
            get
            {
                return _sexEnum;
            }
        }

        [Column(Name = "BodyweightKg")]
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if ((this._weight != value))
                {
                    this._weight = value;
                }
            }
        }

        [Column(Name = "Equipment")]
        private string _Equipment
        {
            set
            {
                if ((this._equipment != value))
                {
                    Enums.EnumParser.Parse(value, out _equipmentEnum);
                    this._equipment = value;
                }
            }
        }
        

        public Enums.Equipment Equipment
        {
            get
            {
                return _equipmentEnum;
            }
        }

        [Column(Name = "Age")]
        public double Age
        {
            get
            {
                return _age;
            }
            set
            {
                if ((this._age != value))
                {
                    this._age = value;
                }
            }
        }

        [Column(Name = "Best3SquatKg")]
        public double Squat
        {
            get
            {
                return _squat;
            }
            set
            {
                if ((this._squat != value))
                {
                    this._squat = value;
                }
            }
        }

        [Column(Name = "Best3BenchKg")]
        public double Bench
        {
            get
            {
                return _bench;
            }
            set
            {
                if ((this._bench != value))
                {
                    this._bench = value;
                }
            }
        }

        [Column(Name = "Best3DeadliftKg")]
        public double Deadlift
        {
            get
            {
                return _deadlift;
            }
            set
            {
                if ((this._deadlift != value))
                {
                    this._deadlift = value;
                }
            }
        }

        [Column(Name = "TotalKg")]
        public double TotalKg
        {
            get
            {
                return _totalKg;
            }
            set
            {
                if ((this._totalKg != value))
                {
                    this._totalKg = value;
                }
            }
        }

        [Column(Name = "Place")]
        public int Place
        {
            get
            {
                return _place;
            }
            set
            {
                if ((this._place != value))
                {
                    this._place = value;
                }
            }
        }

        [Column(Name = "Tested")]
        private string _Tested
        {
            set
            {
                if ((this._tested != value))
                {
                    Enum.TryParse(value, out _testedEnum);
                    this._tested = value;
                }
            }
        }

        public Enums.Tested Tested
        {
            get
            {
                return _testedEnum;
            }
        }

        [Column(Name = "MeetName")]
        private string _MeetName
        {
            set
            {
                if ((this._meetName != value))
                {
                    Enums.EnumParser.Parse(value, out _meetNameEnum);
                    this._meetName = value;
                }
            }
        }

        public Enums.MeetName MeetName
        {
            get
            {
                return _meetNameEnum;
            }
        }

        [Column(Name = "Wilks")]
        public double Wilks { get; set; }

        [Column(Name = "McCulloch")]
        public double McCulloch { get; set; }

        [Column(Name = "Glossbrenner")]
        public double Glossbrenner { get; set; }

        [Column(Name = "IPFPoints")]
        public double IPFPoints { get; set; }
    }
}
