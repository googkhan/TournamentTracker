using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            //Connection = new List<IDataConnections>(); // dotnet 6dan oncesi icin boyle imiş

            if(db == DatabaseType.Sql)
            {
                // TODO set up the sql connector properly

                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if(db == DatabaseType.TextFile)
            {
                // TODO create text connection ex fileio

                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
