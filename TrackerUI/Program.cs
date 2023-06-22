using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            //Application.Run(new TournamentDashboardForm());
            Application.Run(new CreatePrizeForm());
			

        }
    }
}
