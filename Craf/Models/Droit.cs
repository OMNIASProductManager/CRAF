using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AppliFacilityzCRAF.Models
{
    [Table("Droits")]
    public class Droit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DroitId { get; set; }
        public string libelleDroit{ get; set; }
    }
}
