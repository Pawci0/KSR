using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.DataModel
{
    public partial class LiftingDataContext : DataContext
    {
        public LiftingDataContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }

        public LiftingDataContext(IDbConnection connection) : base(connection)
        {
        }

        public LiftingDataContext(string fileOrServerOrConnection, MappingSource mapping) : base(fileOrServerOrConnection, mapping)
        {
        }

        public LiftingDataContext(IDbConnection connection, MappingSource mapping) : base(connection, mapping)
        {
        }

        public System.Data.Linq.Table<Entry> Entry
        {
            get
            {
                return GetTable<Entry>();
            }
        }
    }
}
