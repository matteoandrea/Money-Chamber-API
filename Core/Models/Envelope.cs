﻿using ProjectS.Core.Core.Objects;
using ProjectS.Core.Models;
using ProjectS.Core.Shared.ValueObjects;
using ProjectS.Core.ValueObjects;

namespace ProjectS.Core.Features.Envelopes.Core;

public class Envelope : Entity
{
	public Envelope(
		Guid userId,
		Name name,
		EnvelopeType type,
		BasicMoneyDetail details,
		Season season
		)
	{
		UserId = userId;

		Name = name;
		Type = type;

		Details = details;
		Season = season;

		AddNotifications(Name, Details);
	}


	#region Propreties

	public Guid UserId { get; init; }

	public Name Name { get; init; }
	public BasicMoneyDetail Details { get; init; }

	public EnvelopeType Type { get; init; }
	public Season Season { get; init; }

	public IEnumerable<Section> Sections { get; init; } = Enumerable.Empty<Section>();
	public IEnumerable<SectionGroup> SectionsGroup { get; init; } = Enumerable.Empty<SectionGroup>();

	#endregion
}
