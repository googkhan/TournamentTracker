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
        /// prize amount in tournament if zero it isnt used
        /// </summary>
        public decimal PrizeAmount { get; set; }


        /// <summary>
        /// prize percent of team won from total fees
        /// </summary>
        public double PrizePercentage { get; set; }




        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;



        }


    }
}
