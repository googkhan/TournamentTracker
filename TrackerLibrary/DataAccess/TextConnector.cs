using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TrackerLibrary.DataAccess.TextConnector;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();

            // TODO wire up the CreatePrize for text files

            //model.Id = 1;
            //return model;

            // TODO - text connections tasks
            // find max id
            // add new record with new id
            // convert prizes to list<string>
            // save list<string> to text file

            // load text file
            // convert text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;
            // currentId += 1; //record one by one in this method

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

        }
    }
}
