using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Faire en sorte que CreatePrize sauvegarde vraiment sur un fichier texte
        /// <summary>
        /// Sauvegarde le nouveau prix dans le fichier texte
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
