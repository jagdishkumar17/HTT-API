
﻿using HTT.FilterTypes;
﻿using Microsoft.AspNetCore.Http;
using HTT.Helpers;
using HTT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTT.Manager.Contract
{
    /// <summary>
    /// interface for ContentDetailService 
    /// </summary>
    public interface IHealthTrackService
    {

        /// <summary>
        ///  Create the CreateHealthTrack
        /// </summary>
        /// <param name="healthTrackViewModel"></param>
        /// <returns></returns>
        Task<IResult> CreateHealthTrack(HealthTrackViewModel healthTrackViewModel);
    }

}
