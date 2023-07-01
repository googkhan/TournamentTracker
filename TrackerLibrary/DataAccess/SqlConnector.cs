using Dapper;
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
        public PersonModel CreatePerson(PersonModel model)
        {
            //throw new NotImplementedException();
            ////TODO - sql baglanmadi
            //p.FirstName = firstNameValue.Text;
            //p.LastName = lastNameValue.Text;
            //p.EmailAddress = emailValue.Text;
            //p.CellphoneNumber = phoneValue.Text;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                //TODO "dbo.spPeople_Insert" storedprocedure missing
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                
                return model;

            }
        }

        // TODO - make CreatePrize method actually save to db

        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();
            //model.Id = 1;

            //@PlaceNumber int,
            //@PlaceName nvarchar(50),
            //@PrizeAmount money,
            //@PrizePercentage float,
            //@id int = 0 output

            //TODO - there is error on cnnstring stuff on DESKTOP-9JGD8UL
            // 'using' state prevent memory leaks, kinda closes connection after beside try/catch

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                //dynamicparameters dapper.nuget'ten
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;

            }
            //TODO - temp. remove after sql connection
            //return model;
        }
    }
}
