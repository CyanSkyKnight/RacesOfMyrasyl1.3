using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RacesofMyrasyl.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class JungleMothWings : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("'Has a fast air speed, but can't fly very high.'");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Cyan;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 80;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1.5f;
			constantAscend = 0.135f;
		}
		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration) {
			speed = 7f;
			acceleration *= 2.5f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(575, 20);
			recipe.AddIngredient(ItemID.ButterflyDust, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}