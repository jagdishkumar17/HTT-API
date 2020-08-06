using HTT.FilterTypes;
using HTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTT.Repository.Contracts
{
    /// <summary>
    /// HealthTrackRepository 
    /// </summary>
    public interface IHealthTrackRepository
    {

        /// <summary>
        ///  This method is used to save new health track
        /// </summary>
        /// <param name="healthTrack"></param>
        /// <returns></returns>
        Task<HealthTrack> CreateHealthTrack(HealthTrack healthTrack);
      
    }
}
