using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Facilityz.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public string adresse { get; set; }

        public string codePostal { get; set; }  
     
        public string ville { get; set; }

        public string matricule { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is is not valid.")]
        public string adresseMail { get; set; }

        //[RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}", ErrorMessage = "Le mot de passe doit contenir au moins un nombre, une majuscule, une minuscule, et au moins 8 caractères")]
        public string mdp { get; set; }
        
        public string marqueVehicule { get; set; }

        public string permis { get; set; }

        public string carteGrise { get; set; }

        public string personneAJoindre { get; set; }

        public string diplome { get; set; }

        public int FonctionId { get; set; }

        public int TypeVehiculeId { get; set; }

        public int DroitId { get; set; }

        public string numTel { get; set; }

        public DateTime derniereVisitemedicale { get; set; }

        public string numSS { get; set; }

        public int anciennete { get; set; }

        public DateTime dateEmbauche { get; set; }
     
        public string fonctionDepuisEmbauche { get; set; }

        public string rattachementAdministrateur { get; set; }

        public string IBANRIB { get; set; }

        public string rattachementHierarchique { get; set; }

        public decimal coefficient { get; set; }

        public int SocieteId { get; set; }

        public int StatutId { get; set; }

        public int TypeValidationId { get; set; }
    }
}
