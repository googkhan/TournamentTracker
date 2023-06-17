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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            //Connections = new List<IDataConnections>(); // dotnet 6dan oncesi icin boyle imiş
            
            if(database)
            {
                // TODO set up the sql connector properly

                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                // TODO create text connection ex fileio

                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
