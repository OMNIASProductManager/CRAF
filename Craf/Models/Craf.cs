using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AppliFacilityzCRAF.Models;

namespace Facilityz.Models
{
    [Table("Craf")]
    public class Craf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrafId { get; set; }

        [Required(ErrorMessage = "champ requis")]
        public int AM_MissionId { get; set; }
        public int PM_MissionId { get; set; }
        public int UserId{ get; set; }
        public DateTime dateCraf { get; set; }
        public int AM_CodeId { get; set; }
        public int PM_CodeId { get; set; }
        public string AM_cheminJustificatif { get; set; }
        public string PM_cheminJustificatif { get; set; }
        public int AM_JustificatifId { get; set; }
        public int PM_JustificatifId { get; set; }
        public decimal AM_montant { get; set; }
        public decimal PM_montant { get; set; }
        public int AM_ActiviteId { get; set; }
        public int PM_ActiviteId { get; set; }
        public DateTime AM_arr { get; set; }
        public DateTime AM_dep { get; set; }
        public DateTime PM_arr { get; set; }
        public DateTime PM_dep { get; set; }

        [StringLength(50, ErrorMessage = "La longueur du {0} doit comprendre plus de {2} caractrère(max:{1}) .", MinimumLength = 2)]
        public string AM_commentaire { get; set; }
        public string PM_commentaire { get; set; }

    }
}
