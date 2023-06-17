using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - make CreatePrize method actually save to db

        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();
            //model.Id = 1;
            //return model;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))
            {



            }
        }
    }
}
