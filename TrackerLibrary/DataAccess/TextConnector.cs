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
        private const string PersonsFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            //throw new NotImplementedException();
            //TODO text baglanmadi
            List<PersonModel> people = PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO - text connections tasks
            // add new record with new id
            // convert prizes to list<string>
            // save list<string> to text file
            // load text file
            // convert text to List<PrizeModel>

            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            // currentId += 1; //record one by one in this method

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
