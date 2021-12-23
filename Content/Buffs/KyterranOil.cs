using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace RacesofMyrasyl.Content.Buffs
{
    public class KyterranOil : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ignited Oil");
            Description.SetDefault("-2 defense. Need time to secrete more oil.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 2; 
        }
    }
}