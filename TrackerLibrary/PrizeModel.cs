using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// properties of a tournament
    /// </summary>
    public class PrizeModel
    {

        /// <summary>
        /// unique identifier for prize
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// place of team in tournament
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// place name of team in tournament
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// prize percent of team won from total fees
        /// </summary>
        public double PrizePercent { get; set; }


    }
}
