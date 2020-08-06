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
    /// HealthTrack
    /// </summary>
    public class HealthTrackSymptomViewModel
    {
        /// <summary>
        /// primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// HealthTrackId
        /// </summary>
        public int HealthTrackId { get; set; }

        /// <summary>
        /// SymptomId
        /// </summary>
        public int SymptomId { get; set; }

        /// <summary>
        /// Symptom Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public bool value { get; set; }

    }
}
