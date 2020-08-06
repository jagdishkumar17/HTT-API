using Microsoft.EntityFrameworkCore;
using HTT.Enums;
using HTT.Models;
using HTT.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTT.FilterTypes;

namespace HTT.Repository.Services
{
    /// <summary>
    ///HealthTrackRepository
    /// Here all method should be async
    /// </summary>
    public class HealthTrackRepository : IHealthTrackRepository
    {
        private readonly Context _context;

        /// <summary>
        /// Ctor
        /// context injection\creation
        /// </summary>
        /// <param name="context"></param>
        public HealthTrackRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// This method is used to Create Health Track
        /// </summary>       
        public async Task<HealthTrack> CreateHealthTrack(HealthTrack healthTrack)
        {
            try
            {
                _context.HealthTrack.Add(healthTrack);
                await _context.SaveChangesAsync();
                return healthTrack;
            }
            catch(Exception ex)
            {
                return healthTrack;
            }
           
        }
    }
}



