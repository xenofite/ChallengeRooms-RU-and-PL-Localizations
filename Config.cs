using System.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using ChallengeRooms.Content.Tiles;
using System.ComponentModel;

namespace ChallengeRooms
{
	public class ChallengeConfig : ModConfig
	{
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Range(0.1f, 1f)]
        [Increment(.1f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float Frequency;
    }
}
