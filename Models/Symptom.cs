using HTT.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HTT.Models
{
    /// <summary>
    /// Symptom
    /// </summary>
    public class Symptom
    {
        /// <summary>
        /// primary key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Symptom Name
        /// </summary>
        [Required, Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        /// <summary>
        /// Symptom position\order
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Symptom status
        /// </summary>
        public EntityStatus Status { get; set; }

    }
}
