using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace RacesofMyrasyl.Content.Buffs
{
	public class SaturnianWing : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Moth Flutter");
			Description.SetDefault("Equipping Saturnian Wings lets you fly!");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}
	}
}