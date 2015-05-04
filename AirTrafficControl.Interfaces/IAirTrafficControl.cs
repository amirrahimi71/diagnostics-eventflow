﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace AirTrafficControl.Interfaces
{
    public interface IAirTrafficControl : IActor
    {
        Task<IEnumerable<string>> GetFlyingAirplaneIDs();

        Task StartNewFlight(string airplaneID, FlightPlan flightPlan);
    }
}
