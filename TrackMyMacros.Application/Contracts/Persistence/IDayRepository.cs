﻿using CSharpFunctionalExtensions;
using TrackMyMacros.Domain.Aggregates.Day;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IDayRepository
{
    Task<Maybe<Day>> GetByDateAsync(DateOnly date);
    Task UpdateAsync(Day day);
}