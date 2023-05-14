/*using System.ComponentModel.DataAnnotations;*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraiseUS.Models
{
    public class Locataire
    {

        ///<summary>
        /// Gets or sets LocataireId
        /// </summary>
        public int locataireId { get; set; }

        ///<summary>
        /// Gets or sets nom
        /// </summary>
        public string nom { get; set; }

        ///<summary>
        /// Gets or sets prenom
        /// </summary>
        public string prenom { get; set; }

        ///<summary>
        /// Gets or sets nationalite
        /// </summary>
        public string nationalite { get; set; }

        ///<summary>
        /// Gets or sets dateDeNaissance
        /// </summary>
        public DateTime dateDeNaissance { get; set; }

        ///<summary>
        /// Gets or sets inscriptionDate
        /// </summary>
        public DateTime inscriptionDate { get; set; }
    }

}
