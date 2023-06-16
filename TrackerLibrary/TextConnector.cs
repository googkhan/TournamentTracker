using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();

            // TODO wire up the CreatePrize for text files

            model.Id = 1;

            return model;

        }
    }
}
