﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireEffect : BaseAction
    {
        [JsonProperty] public readonly string effectPattern;
    }
}
