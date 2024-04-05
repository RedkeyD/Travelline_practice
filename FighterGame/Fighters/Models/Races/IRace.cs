﻿namespace Fighters.Models.Races;

public interface IRace
{
    string Name { get; }
    int Speed { get; }
    int Damage { get; }
    int Health { get; }
    int Armor { get; }
}