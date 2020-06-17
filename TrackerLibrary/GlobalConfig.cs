using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void  InitializeConnections(bool database, bool textfiles)
        {
            if(database)
            {
                // TODO - Setup the sql connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }

            if (textfiles)
            {
                // TODO - Create the Text file connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
 