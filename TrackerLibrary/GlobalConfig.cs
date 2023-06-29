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
        public static IDataConnection Connections { get; private set; }
        public static void InitializeConnections(string connectionType)
        {
            //Connections = new List<IDataConnections>(); // dotnet 6dan oncesi icin boyle imiş
            
            if(connectionType == "sql")
            {
                // TODO set up the sql connector properly

                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }

            else if(connectionType == "text")
            {
                // TODO create text connection ex fileio

                TextConnector text = new TextConnector();
                Connections = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
