using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataonnection> Connections { get; private set; } = new List<IDataonnection>();

        public static void InitializeConnections(bool database, bool textfile)
        {
            if (database) // équivalent à "database == true" car c'est un booleen
            {
                // TODO - Setup la connection MySQL
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textfile)
            {
                // TODO - Lier a un fichier texte
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
