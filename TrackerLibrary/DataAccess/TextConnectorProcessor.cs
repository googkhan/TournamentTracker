using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string filename) // like PrizeModels.csv
        {
            // like C:\\data\TournamentTracker\PrizeModels.csv path creator
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
        }
    }
}
