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
    [Table("Societe")]
    public class Societe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SocieteId{ get; set; }
        public string libelleSociete{ get; set; }
        public string codeNAF{ get; set; }
        public string adresseSociete{ get; set; }
    }
}
