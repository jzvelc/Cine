﻿using System;
using Convey.CQRS.Events;

namespace Cine.Modules.Cinemas.Api.Events
{
    public sealed class HallAdded : IEvent
    {
        public Guid CinemaId { get; }
        public Guid HallId { get; }

        public HallAdded(Guid cinemaId, Guid hallId)
        {
            CinemaId = cinemaId;
            HallId = hallId;
        }
    }
}
