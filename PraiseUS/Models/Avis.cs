using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraiseUS.Models
{
    public class Avis
    {
        [Key]
        public int avisId { get; set; }

        public int note { get; set; }

        public string commentaire { get; set; }

        public DateTime avisDate { get; set; }

        public int locataireId { get; set; }

        //public virtual Locataire locataire { get; set; }
    }
}