﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void  InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }
            //if(db == DatabaseType.Sql)
            //{
            //    // TODO - Setup the sql connector properly
            //    SqlConnector sql = new SqlConnector();
            //    Connections= sql;

            //}else if (db == DatabaseType.TextFile)
            //{
            //    // TODO - Create the Text file connection
            //    TextConnector text = new TextConnector();
            //    Connections = text;
            //}
        }
        public static string CnnString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
 