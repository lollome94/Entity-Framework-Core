using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Plant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public double NominalPower { get; set; } = 0;


        public int SubstationId { get; set; }

        [ForeignKey("SubstationId")]
        public Substation Substation { get; set; }
    }
}
