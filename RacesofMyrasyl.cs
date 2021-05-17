using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace RacesofMyrasyl
{
	public class RacesofMyrasyl : Mod
	{
		public static RacesofMyrasyl Instance { get; private set; }
		public override void Load()
		{
			MrPlagueRaces.Core.Loadables.LoadableManager.Autoload(this);
			if (!Main.dedServ)
			{
				// Add certain equip textures
				AddEquipTexture(null, EquipType.Legs, "cskVoidMageRobe_Legs", "RacesofMyrasyl/Items/Armor/cskVoidMageRobe_Legs");
			}
		}
		public override void Unload()
		{
			MrPlagueRaces.Common.Races.RaceLoader.Races.Clear();
			MrPlagueRaces.Common.Races.RaceLoader.RacesByLegacyIds.Clear();
			MrPlagueRaces.Common.Races.RaceLoader.RacesByFullNames.Clear();
		}
			

	}
}
