using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Représente une personne
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Prénom de la personne
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Nom de la famille de la personne
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Adresse email de la personne
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// Numéro de téléphone de la personne
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
