using System.ComponentModel.DataAnnotations;

namespace PraiseUS.Models
{
    public class Avis
    {
        [Key]
        public int avisId { get; set; }

        public int note { get; set; }

        public string commentaire { get; set; }

        public DateTime avisDate { get; set; }

        public virtual Locataire locataire { get; set; }
    }
}