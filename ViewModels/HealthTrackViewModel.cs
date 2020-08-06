using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HTT.Enums;
using HTT.Models;
namespace HTT.ViewModels
{
    /// <summary>
    /// Health Track View Model
    /// </summary>
    public class HealthTrackViewModel
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ResidentialAddress
        /// </summary>
        public string ResidentialAddress { get; set; }

        /// <summary>
        /// PreExistHealthIssue
        /// </summary>
        public bool PreExistHealthIssue { get; set; }

        /// <summary>
        /// ContactWithCovidPeople
        /// </summary>
        public bool ContactWithCovidPeople { get; set; }

        /// <summary>
        /// TravelOustSideInLast15Days
        /// </summary>
        public bool TravelOustSideInLast15Days { get; set; }

        /// <summary>
        /// SampleDate
        /// </summary>
        public DateTime SampleDate { get; set; }

        /// <summary>
        /// LocationId
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// file checked out by user
        /// </summary>
        public int ZoneId { get; set; }
        /// <summary>
        /// created by user id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        ///Health Track Symptoms
        /// </summary>
        public List<HealthTrackSymptomViewModel> HealthTrackSymptoms { get; set; }

        /// <summary>
        ///Health Track Question Answer ViewModel
        /// </summary>
        public List<HealthTrackQuestionAnswerViewModel> HealthTrackQuestions { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public EntityStatus Status { get; set; }
    }
}
