using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();

            // TODO wire up the CreatePrize for text files

            //model.Id = 1;
            //return model;

            //TODO - text connections tasks
            // load text file
            // convert text to List<PrizeModel>
            // find max id
            // add new record with new id
            // convert prizes to list<string>
            // save list<string> to text file



        }
    }
}
