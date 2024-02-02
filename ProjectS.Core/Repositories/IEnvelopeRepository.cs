﻿using ProjectS.Core.Core.Command;
using ProjectS.Core.Features.Envelopes.Core;

namespace ProjectS.Core.Repositories;

public interface IEnvelopeRepository : IRepository
{
	Task CreateAsync(Envelope envelope);
	Task CreateAsync(IEnumerable<Envelope> envelopes);
}
