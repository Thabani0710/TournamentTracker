using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        // TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the textfile and  Convert the test to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeMode();

            // Find the max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currentId;
            // Add the new recors with the new ID (max +1)
            prizes.Add(model);
            // Convert the prizes to list<string>
            // Save the list<string> to the test file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
        
    }
}
