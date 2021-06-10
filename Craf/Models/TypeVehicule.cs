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
    [Table("TypeVehicule")]
    public class TypeVehicule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeVehiculeId { get; set; }
        public string libelleTypeVehicule { get; set; }
    }
}
