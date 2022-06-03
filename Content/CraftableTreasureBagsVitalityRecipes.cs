using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.DataStructures;
using Terraria.UI;
using Terraria.ID;
using Terraria.IO;
using Terraria.Social;
using Terraria.ModLoader;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.Utilities;
using Terraria.WorldBuilding;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader.IO;
using Terraria.Localization;
using System.Runtime.InteropServices;
using ReLogic.Graphics;
using Terraria.GameContent.UI;
using Terraria.GameContent.ItemDropRules;

namespace CraftableMasterModeRelics
{
	public class CraftableTreasureBagsVitalityRecipes : ModSystem
	{

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("VitalityMod", out var VitalityMod)) return;
			{
				if (!ModContent.TryFind("VitalityMod/StormCloudRelic", out ModItem StormCloudRelic)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/GrandAntlionRelic", out ModItem GrandAntlionRelic)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/MoonlightDragonflyRelic", out ModItem MoonlightDragonflyRelic)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/DreadnaughtRelic", out ModItem DreadnaughtRelic)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/AnarchulesBeetleRelic", out ModItem AnarchulesBeetleRelic)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/ChaosbringerRelic", out ModItem ChaosbringerRelic)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/PaladinSpiritRelic", out ModItem PaladinSpiritRelic)) return; //VitalityMod

				StormCloudRelic.CreateRecipe()
				.AddIngredient(ItemID.GoldBar, 25)
				.AddIngredient(VitalityMod, "CloudCore")
				.AddIngredient(ItemID.Umbrella, 1)
				.AddIngredient(ItemID.UmbrellaHat, 1)
				.AddIngredient(VitalityMod, "StormCloudMask")
				.AddIngredient(VitalityMod, "StormCloudTrophy")
				.AddIngredient(VitalityMod, "StormsBlessing")
				.AddIngredient(ItemID.GoldCoin, 10)
				.AddTile(TileID.DemonAltar)
				.AddTile(TileID.Anvils)
				.Register(); //Storm Cloud (Gold) (P1 Mask)

				StormCloudRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "CloudCore").AddIngredient(ItemID.Umbrella, 1).AddIngredient(ItemID.UmbrellaHat, 1).AddIngredient(VitalityMod, "StormCloudMask").AddIngredient(VitalityMod, "StormCloudTrophy").AddIngredient(VitalityMod, "StormsBlessing").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Storm Cloud (Platinum) (P1 Mask)
				StormCloudRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "CloudCore").AddIngredient(ItemID.Umbrella, 1).AddIngredient(ItemID.UmbrellaHat, 1).AddIngredient(VitalityMod, "StormCloudMask2").AddIngredient(VitalityMod, "StormCloudTrophy").AddIngredient(VitalityMod, "StormsBlessing").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Storm Cloud (Gold) (P2 Mask)
				StormCloudRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "CloudCore").AddIngredient(ItemID.Umbrella, 1).AddIngredient(ItemID.UmbrellaHat, 1).AddIngredient(VitalityMod, "StormCloudMask2").AddIngredient(VitalityMod, "StormCloudTrophy").AddIngredient(VitalityMod, "StormsBlessing").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Storm Cloud (Platinum) (P2 Mask)

				GrandAntlionRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "AncientCrown").AddIngredient(VitalityMod, "AntlionHide").AddIngredient(ItemID.BananaSplit).AddIngredient(VitalityMod, "GrandAntlionMask").AddIngredient(VitalityMod, "GrandAntlionTrophy").AddIngredient(VitalityMod, "AntlionDiggingClaw").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Grand Antlion (Gold)
				GrandAntlionRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "AncientCrown").AddIngredient(VitalityMod, "AntlionHide").AddIngredient(ItemID.BananaSplit).AddIngredient(VitalityMod, "GrandAntlionMask").AddIngredient(VitalityMod, "GrandAntlionTrophy").AddIngredient(VitalityMod, "AntlionDiggingClaw").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Grand Antlion (Platinum)

				MoonlightDragonflyRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "MoonlightLotusFlower").AddIngredient(ItemID.ShrimpPoBoy).AddIngredient(VitalityMod, "MoonlightDragonflyMask").AddIngredient(VitalityMod, "MoonlightDragonflyTrophy").AddIngredient(VitalityMod, "DragonflyPendant").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Moonlight Dragonfly (Gold)
				MoonlightDragonflyRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "MoonlightLotusFlower").AddIngredient(ItemID.ShrimpPoBoy).AddIngredient(VitalityMod, "MoonlightDragonflyMask").AddIngredient(VitalityMod, "MoonlightDragonflyTrophy").AddIngredient(VitalityMod, "DragonflyPendant").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Moonlight Dragonfly (Platinum)

				// Hardmode Recipes Start Here

				DreadnaughtRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "Dreadcandle").AddIngredient(ItemID.Hotdog).AddIngredient(VitalityMod, "DreadnaughtMask").AddIngredient(VitalityMod, "DreadnaughtTrophy").AddIngredient(VitalityMod, "CoreOfWrath").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Dreadnaught (Gold)
				DreadnaughtRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "Dreadcandle").AddIngredient(ItemID.Hotdog).AddIngredient(VitalityMod, "DreadnaughtMask").AddIngredient(VitalityMod, "DreadnaughtTrophy").AddIngredient(VitalityMod, "CoreOfWrath").AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Dreadnaught (Platinum)

				AnarchulesBeetleRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "AnarchyCrystal").AddIngredient(ItemID.PigPetItem).AddIngredient(VitalityMod, "AnarchulesBeetleMask").AddIngredient(VitalityMod, "AnarchulesBeetleTrophy").AddIngredient(VitalityMod, "AnarchyCape").AddIngredient(VitalityMod, "AnarchyBar", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Anarchules Beetle (Gold) (Corruption)
				AnarchulesBeetleRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "AnarchyCrystal").AddIngredient(ItemID.PigPetItem).AddIngredient(VitalityMod, "AnarchulesBeetleMask").AddIngredient(VitalityMod, "AnarchulesBeetleTrophy").AddIngredient(VitalityMod, "AnarchyCape").AddIngredient(VitalityMod, "AnarchyBar", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Anarchules Beetle (Platinum) (Corruption)
				AnarchulesBeetleRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "AnarchyCrystalCrimson").AddIngredient(ItemID.PigPetItem).AddIngredient(VitalityMod, "AnarchulesBeetleCrimsonMask").AddIngredient(VitalityMod, "AnarchulesBeetleCrimsonTrophy").AddIngredient(VitalityMod, "AnarchyCapeCrimson").AddIngredient(VitalityMod, "AnarchyBarCrimson", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Anarchules Beetle (Gold) (Crimson)
				AnarchulesBeetleRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "AnarchyCrystalCrimson").AddIngredient(ItemID.PigPetItem).AddIngredient(VitalityMod, "AnarchulesBeetleCrimsonMask").AddIngredient(VitalityMod, "AnarchulesBeetleCrimsonTrophy").AddIngredient(VitalityMod, "AnarchyCapeCrimson").AddIngredient(VitalityMod, "AnarchyBarCrimson", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Anarchules Beetle (Gold) (Crimson)

				ChaosbringerRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "TotemofChaos").AddIngredient(ItemID.ApplePie).AddIngredient(VitalityMod, "ChaosbringerMask").AddIngredient(VitalityMod, "ChaosbringerTrophy").AddIngredient(VitalityMod, "ChaosMantle").AddIngredient(VitalityMod, "ChaosCrystal", 200).AddIngredient(VitalityMod, "ChaosBar", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Chaosbringer (Gold)
				ChaosbringerRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "TotemofChaos").AddIngredient(ItemID.ApplePie).AddIngredient(VitalityMod, "ChaosbringerMask").AddIngredient(VitalityMod, "ChaosbringerTrophy").AddIngredient(VitalityMod, "ChaosMantle").AddIngredient(VitalityMod, "ChaosCrystal", 200).AddIngredient(VitalityMod, "ChaosBar", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Chaosbringer (Platinum)

				PaladinSpiritRelic.CreateRecipe().AddIngredient(ItemID.GoldBar, 25).AddIngredient(VitalityMod, "SpiritBox").AddIngredient(ItemID.BBQRibs).AddIngredient(VitalityMod, "Ectosoul", 50).AddIngredient(VitalityMod, "PaladinSpiritMask").AddIngredient(VitalityMod, "PaladinSpiritTrophy").AddIngredient(VitalityMod, "SpiritPouch").AddIngredient(VitalityMod, "EquityCore", 2).AddIngredient(VitalityMod, "SoulofVitality", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Paladin Spirit (Gold)
				PaladinSpiritRelic.CreateRecipe().AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(VitalityMod, "SpiritBox").AddIngredient(ItemID.BBQRibs).AddIngredient(VitalityMod, "Ectosoul", 50).AddIngredient(VitalityMod, "PaladinSpiritMask").AddIngredient(VitalityMod, "PaladinSpiritTrophy").AddIngredient(VitalityMod, "SpiritPouch").AddIngredient(VitalityMod, "EquityCore", 2).AddIngredient(VitalityMod, "SoulofVitality", 80).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Paladin Spirit (Platinum)
			}
		}
	}
}