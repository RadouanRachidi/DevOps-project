using System.ComponentModel.DataAnnotations;

namespace PraiseUS.Models
{
    public class Locataire
    {
        [Key]
        public int locataireId { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public string nationalite { get; set; }

        public DateTime dateDeNaissance { get; set; }


        public DateTime inscriptionDate { get; set; }
    }
}