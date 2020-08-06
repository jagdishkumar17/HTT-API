using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTT.Models;


namespace HTT.Repository
{
    /// <summary>
    /// Offer portal db set
    /// </summary>
    public partial class Context
    {

        #region Master tables

        /// <summary>
        /// Locations
        /// </summary>
        public DbSet<Location> Location { get; set; }


        /// <summary>
        /// Zones
        /// </summary>
        public DbSet<Zone> Zone { get; set; }


        /// <summary>
        /// Symptoms
        /// </summary>
        public DbSet<Symptom> Symptom { get; set; }


        /// <summary>
        /// Questions
        /// </summary>
        public DbSet<Question> Question { get; set; }

      

        #endregion

        /// <summary>
        /// Employee
        /// </summary>
        public DbSet<Employee> Employee { get; set; }

        /// <summary>
        /// HealthTrack
        /// </summary>
        public DbSet<HealthTrack> HealthTrack { get; set; }

        /// <summary>
        /// HealthTrackQuestionAnswer
        /// </summary>
        public DbSet<HealthTrackQuestionAnswer> HealthTrackQuestionAnswer { get; set; }

        /// <summary>
        /// HealthTrackSymptom
        /// </summary>
        public DbSet<HealthTrackSymptom> HealthTrackSymptom { get; set; }





    }
}
