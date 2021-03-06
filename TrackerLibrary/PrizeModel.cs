﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Représente les prix à gagner
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// N° dans le classement
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Nom de la place (argent, or, champion, nul,...)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Somme remportée par le concurrent a cette position
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Pourcentage à partir duquel est calculé la somme remportée par le concurrent a cette position
        /// </summary>
        public double PricePercentage { get; set; }
    }
}
