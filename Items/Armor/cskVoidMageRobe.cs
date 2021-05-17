using Terraria.ModLoader;
using Terraria.ID;

namespace RacesofMyrasyl.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	internal class cskVoidMageRobe : ModItem
	{
		public override void SetDefaults() {
			item.width = 18;
			item.height = 14;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes) {
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("cskVoidMageRobe_Legs", EquipType.Legs);
		}

		public override void DrawHands(ref bool drawHands, ref bool drawArms) {
			drawHands = true;
		}
	}
}
