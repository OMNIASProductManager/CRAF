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
    [Table("Justificatif")]
    public class Justificatif
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JustificatifId { get; set; }
        public string libelleJustificatif { get; set; }
        public string cheminJustificatif { get; set; }
        public bool justifiable{ get; set; }
    }
}
