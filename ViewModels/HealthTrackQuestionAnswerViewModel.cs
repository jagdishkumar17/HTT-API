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
    /// HealthTrackQuestionAnswerViewModel
    /// </summary>
    public class HealthTrackQuestionAnswerViewModel
    {
        /// <summary>
        /// primary key
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// HealthTrack ForeignKey
        /// </summary>
        public int HealthTrackId { get; set; }


        /// <summary>
        /// Question ForeignKey
        public int QuestionId { get; set; }


        /// <summary>
        /// Question 
        public string Question { get; set; }


        /// <summary>
        /// value
        /// </summary>
        public string value { get; set; }

    }
}
