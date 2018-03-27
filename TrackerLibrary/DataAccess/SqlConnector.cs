using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Faire en sorte que CreatePrize sauvegarde vraiment sur la database
        /// <summary>
        /// Sauvegarde le nouveau prix dans la database
        /// </summary>
        /// <param name="model">Information du prix</param>
        /// <returns>L'information du prix et son identifiant unique</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
