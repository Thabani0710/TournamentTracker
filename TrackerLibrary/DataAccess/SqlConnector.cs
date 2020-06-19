﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary.Models;

//@PlaceNumber int,
//@PlaceName nvarchar(50),
//@PrizeAmount money,
//@PrizePercentage float,
//@id int = 0 output

namespace TrackerLibrary.DataAccess
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
            // The statements ensure that we open a new connection to the database and close it off once the we hit the last }, It avoids memory leaks
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType:DbType.Int32, direction: ParameterDirection.Output );

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");

                return model;

            }

           
        }
    }
}
