﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the create prize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database 
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, Including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;

            return model;
        }
    }
}
