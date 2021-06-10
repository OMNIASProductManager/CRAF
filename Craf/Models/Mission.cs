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
    [Table("Mission")]
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MissionId { get; set; }
        public string libelleMission{ get; set; }
        public int ClientId{ get; set; }
        public DateTime dateDebut{ get; set; }
        public DateTime dateFin { get; set; }
    }
}
