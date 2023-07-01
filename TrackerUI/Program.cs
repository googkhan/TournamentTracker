using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // initialize the database connections
            //GlobalConfig.InitializeConnections(DatabaseType.TextFile);
            GlobalConfig.InitializeConnections(DatabaseType.Sql);

            //Application.Run(new TournamentDashboardForm());
            //Application.Run(new CreatePrizeForm());
            Application.Run(new CreateTeamForm());

        }
    }
}
