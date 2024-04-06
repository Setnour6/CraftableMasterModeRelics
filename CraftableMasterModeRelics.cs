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
	public class CraftableMasterModeRelics : Mod
	{
		// This class is required
	}
	public class CraftableMasterModeRelicsRecipes : ModSystem
	{
		public override void AddRecipes()/* tModPorter Note: Removed. Use ModSystem.AddRecipes */
		{

			#region Vanilla Master Mode Relics

			/* ((Mod)this) */
			Recipe.Create(ItemID.KingSlimeMasterTrophy, 1)
			.AddIngredient(ItemID.GoldBar, 25)
			.AddIngredient(ItemID.SlimeCrown, 1)
			.AddIngredient(ItemID.Gel, 600)
			.AddIngredient(ItemID.KingSlimeMask, 1)
			.AddIngredient(ItemID.KingSlimeTrophy)
			.AddIngredient(ItemID.RoyalGel, 1)
			.AddIngredient(ItemID.GoldCoin, 10)
			.AddTile(TileID.DemonAltar)
			.AddTile(TileID.Anvils)
			.Register(); //King Slime (Gold)

			Recipe.Create(ItemID.KingSlimeMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.SlimeCrown, 1).AddIngredient(ItemID.Gel, 600).AddIngredient(ItemID.KingSlimeMask, 1).AddIngredient(ItemID.KingSlimeTrophy).AddIngredient(ItemID.RoyalGel, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //King Slime (Platinum)

			Recipe.Create(ItemID.EyeofCthulhuMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.SuspiciousLookingEye, 1).AddIngredient(ItemID.BlackLens, 2).AddIngredient(ItemID.EyeMask, 1).AddIngredient(ItemID.EyeofCthulhuTrophy, 1).AddIngredient(ItemID.EoCShield, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //EOC (gold)
			Recipe.Create(ItemID.EyeofCthulhuMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.SuspiciousLookingEye, 1).AddIngredient(ItemID.BlackLens, 2).AddIngredient(ItemID.EyeMask, 1).AddIngredient(ItemID.EyeofCthulhuTrophy, 1).AddIngredient(ItemID.EoCShield, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //EOC (platinum)

			Recipe.Create(ItemID.EaterofWorldsMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.WormFood, 1).AddIngredient(ItemID.Burger, 1).AddIngredient(ItemID.EaterMask, 1).AddIngredient(ItemID.EaterofWorldsTrophy).AddIngredient(ItemID.WormScarf, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //EOW (gold)
			Recipe.Create(ItemID.EaterofWorldsMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.WormFood, 1).AddIngredient(ItemID.Burger, 1).AddIngredient(ItemID.EaterMask, 1).AddIngredient(ItemID.EaterofWorldsTrophy).AddIngredient(ItemID.WormScarf, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //EOW (platinum)

			Recipe.Create(ItemID.BrainofCthulhuMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.BloodySpine, 1).AddIngredient(ItemID.Burger, 1).AddIngredient(ItemID.BrainMask, 1).AddIngredient(ItemID.BrainofCthulhuTrophy, 3).AddIngredient(ItemID.BrainOfConfusion, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //BOC (gold)
			Recipe.Create(ItemID.BrainofCthulhuMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.BloodySpine, 1).AddIngredient(ItemID.Burger, 1).AddIngredient(ItemID.BrainMask, 1).AddIngredient(ItemID.BrainofCthulhuTrophy, 3).AddIngredient(ItemID.BrainOfConfusion, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //BOC (platinum)

			Recipe.Create(ItemID.QueenBeeMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.Abeemination, 1).AddIngredient(ItemID.CoffeeCup, 1).AddIngredient(ItemID.BeeMask, 1).AddIngredient(ItemID.QueenBeeTrophy, 1).AddIngredient(ItemID.HiveBackpack, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Queen Bee (gold)
			Recipe.Create(ItemID.QueenBeeMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.Abeemination, 1).AddIngredient(ItemID.CoffeeCup, 1).AddIngredient(ItemID.BeeMask, 1).AddIngredient(ItemID.QueenBeeTrophy, 1).AddIngredient(ItemID.HiveBackpack, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Queen Bee (platinum)

			Recipe.Create(ItemID.SkeletronMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.ClothierVoodooDoll, 1).AddIngredient(ItemID.Bone, 400).AddIngredient(ItemID.SkeletronMask, 1).AddIngredient(ItemID.SkeletronTrophy, 1).AddIngredient(ItemID.BoneGlove, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Skeletron (gold)
			Recipe.Create(ItemID.SkeletronMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.ClothierVoodooDoll, 1).AddIngredient(ItemID.Bone, 400).AddIngredient(ItemID.SkeletronMask, 1).AddIngredient(ItemID.SkeletronTrophy, 1).AddIngredient(ItemID.BoneGlove, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Skeletron (platinum)

			Recipe.Create(ItemID.DeerclopsMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.DeerThing, 1).AddIngredient(ItemID.IceCream, 1).AddIngredient(ItemID.DeerclopsMask, 1).AddIngredient(ItemID.DeerclopsTrophy, 1).AddIngredient(ItemID.BoneHelm, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Deerclops (gold)
			Recipe.Create(ItemID.DeerclopsMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.DeerThing, 1).AddIngredient(ItemID.IceCream, 1).AddIngredient(ItemID.DeerclopsMask, 1).AddIngredient(ItemID.DeerclopsTrophy, 1).AddIngredient(ItemID.BoneHelm, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Deerclops (platinum)

			Recipe.Create(ItemID.WallofFleshMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.GuideVoodooDoll, 1).AddIngredient(ItemID.Hotdog, 1).AddIngredient(ItemID.FleshMask, 1).AddIngredient(ItemID.WallofFleshTrophy, 1).AddIngredient(ItemID.ObsidianRose, 1).AddIngredient(ItemID.MagmaStone, 1).AddIngredient(ItemID.HellCake, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //WOF (gold)
			Recipe.Create(ItemID.WallofFleshMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.GuideVoodooDoll, 1).AddIngredient(ItemID.Hotdog, 1).AddIngredient(ItemID.FleshMask, 1).AddIngredient(ItemID.WallofFleshTrophy, 1).AddIngredient(ItemID.ObsidianRose, 1).AddIngredient(ItemID.MagmaStone, 1).AddIngredient(ItemID.HellCake, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //WOF (platinum)

			// Hardmode Recipes Start Here

			Recipe.Create(ItemID.QueenSlimeMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.QueenSlimeCrystal, 1).AddIngredient(ItemID.Gel, 750).AddIngredient(ItemID.QueenSlimeMask, 1).AddIngredient(ItemID.QueenSlimeTrophy, 1).AddIngredient(ItemID.VolatileGelatin, 1).AddIngredient(ItemID.CrystalShard, 100).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Queen Slime (gold)
			Recipe.Create(ItemID.QueenSlimeMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.QueenSlimeCrystal, 1).AddIngredient(ItemID.Gel, 750).AddIngredient(ItemID.QueenSlimeMask, 1).AddIngredient(ItemID.QueenSlimeTrophy, 1).AddIngredient(ItemID.VolatileGelatin, 1).AddIngredient(ItemID.CrystalShard, 100).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Queen Slime (gold)

			Recipe.Create(ItemID.TwinsMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.MechanicalEye, 1).AddIngredient(ItemID.Cog, 100).AddIngredient(ItemID.TwinMask, 1).AddIngredient(ItemID.SpazmatismTrophy, 1).AddIngredient(ItemID.RetinazerTrophy, 1).AddIngredient(ItemID.MechanicalWheelPiece, 1).AddIngredient(ItemID.SoulofSight, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Twins (gold)
			Recipe.Create(ItemID.TwinsMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.MechanicalEye, 1).AddIngredient(ItemID.Cog, 100).AddIngredient(ItemID.TwinMask, 1).AddIngredient(ItemID.SpazmatismTrophy, 1).AddIngredient(ItemID.RetinazerTrophy, 1).AddIngredient(ItemID.MechanicalWheelPiece, 1).AddIngredient(ItemID.SoulofSight, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Twins (platinum)

			Recipe.Create(ItemID.DestroyerMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.MechanicalWorm, 1).AddIngredient(ItemID.Cog, 100).AddIngredient(ItemID.DestroyerMask, 1).AddIngredient(ItemID.DestroyerTrophy, 1).AddIngredient(ItemID.MechanicalWagonPiece, 1).AddIngredient(ItemID.SoulofMight, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Destroyer (gold)
			Recipe.Create(ItemID.DestroyerMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.MechanicalWorm, 1).AddIngredient(ItemID.Cog, 100).AddIngredient(ItemID.DestroyerMask, 1).AddIngredient(ItemID.DestroyerTrophy, 1).AddIngredient(ItemID.MechanicalWagonPiece, 1).AddIngredient(ItemID.SoulofMight, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Destroyer (platinum)

			Recipe.Create(ItemID.SkeletronPrimeMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.MechanicalSkull, 1).AddIngredient(ItemID.Cog, 100).AddIngredient(ItemID.SkeletronPrimeMask, 1).AddIngredient(ItemID.SkeletronPrimeTrophy, 1).AddIngredient(ItemID.MechanicalBatteryPiece, 1).AddIngredient(ItemID.SoulofFright, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Skeletron Prime (gold)
			Recipe.Create(ItemID.SkeletronPrimeMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.MechanicalSkull, 1).AddIngredient(ItemID.Cog, 100).AddIngredient(ItemID.SkeletronPrimeMask, 1).AddIngredient(ItemID.SkeletronPrimeTrophy, 1).AddIngredient(ItemID.MechanicalBatteryPiece, 1).AddIngredient(ItemID.SoulofFright, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Skeletron Prime (platinum)

			Recipe.Create(ItemID.PlanteraMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.TempleKey, 1).AddIngredient(ItemID.ChlorophyteOre, 100).AddIngredient(ItemID.PlanteraMask, 1).AddIngredient(ItemID.PlanteraTrophy, 1).AddIngredient(ItemID.SporeSac, 1).AddIngredient(ItemID.FlowerPacketWild, 50).AddIngredient(ItemID.LifeFruit, 5).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Plantera (gold)
			Recipe.Create(ItemID.PlanteraMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.TempleKey, 1).AddIngredient(ItemID.ChlorophyteOre, 100).AddIngredient(ItemID.PlanteraMask, 1).AddIngredient(ItemID.PlanteraTrophy, 1).AddIngredient(ItemID.SporeSac, 1).AddIngredient(ItemID.FlowerPacketWild, 50).AddIngredient(ItemID.LifeFruit, 5).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Plantera (platinum)

			Recipe.Create(ItemID.GolemMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.LihzahrdPowerCell, 5).AddIngredient(ItemID.BeetleHusk, 20).AddIngredient(ItemID.SolarTablet, 1).AddIngredient(ItemID.GolemMask, 1).AddIngredient(ItemID.GolemTrophy, 1).AddIngredient(ItemID.ShinyStone).AddIngredient(ItemID.Picksaw).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Golem (gold)
			Recipe.Create(ItemID.GolemMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.LihzahrdPowerCell, 5).AddIngredient(ItemID.BeetleHusk, 20).AddIngredient(ItemID.SolarTablet, 1).AddIngredient(ItemID.GolemMask, 1).AddIngredient(ItemID.GolemTrophy, 1).AddIngredient(ItemID.ShinyStone).AddIngredient(ItemID.Picksaw).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Golem (gold)

			Recipe.Create(ItemID.DukeFishronMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.TruffleWorm, 1).AddIngredient(ItemID.Bacon, 3).AddIngredient(ItemID.ShrimpPoBoy, 1).AddIngredient(ItemID.DukeFishronMask, 1).AddIngredient(ItemID.DukeFishronTrophy, 1).AddIngredient(ItemID.ShrimpyTruffle, 1).AddIngredient(ItemID.FishronWings, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Duke Fishron (gold)
			Recipe.Create(ItemID.DukeFishronMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.TruffleWorm, 1).AddIngredient(ItemID.Bacon, 3).AddIngredient(ItemID.ShrimpPoBoy, 1).AddIngredient(ItemID.DukeFishronMask, 1).AddIngredient(ItemID.DukeFishronTrophy, 1).AddIngredient(ItemID.ShrimpyTruffle, 1).AddIngredient(ItemID.FishronWings, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Duke Fishron (gold)

			Recipe.Create(ItemID.FairyQueenMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.EmpressButterfly, 1).AddIngredient(ItemID.CrystalShard, 200).AddIngredient(ItemID.PrismaticPunch, 1).AddIngredient(ItemID.PixieDust, 300).AddIngredient(ItemID.UnicornHorn, 15).AddIngredient(ItemID.FairyQueenMask, 1).AddIngredient(ItemID.FairyQueenTrophy, 1).AddIngredient(ItemID.EmpressFlightBooster, 1).AddIngredient(ItemID.SoulofLight, 100).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Empress of Light (gold)
			Recipe.Create(ItemID.FairyQueenMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.EmpressButterfly, 1).AddIngredient(ItemID.CrystalShard, 200).AddIngredient(ItemID.PrismaticPunch, 1).AddIngredient(ItemID.PixieDust, 300).AddIngredient(ItemID.UnicornHorn, 15).AddIngredient(ItemID.FairyQueenMask, 1).AddIngredient(ItemID.FairyQueenTrophy, 1).AddIngredient(ItemID.EmpressFlightBooster, 1).AddIngredient(ItemID.SoulofLight, 100).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Empress of Light (platinum)

			Recipe.Create(ItemID.LunaticCultistMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.TwilightDye, 1).AddIngredient(ItemID.BossMaskCultist, 1).AddIngredient(ItemID.AncientCultistTrophy, 1).AddIngredient(ItemID.LunarCraftingStation, 1).AddIngredient(ItemID.FragmentNebula, 3).AddIngredient(ItemID.FragmentSolar, 3).AddIngredient(ItemID.FragmentStardust, 3).AddIngredient(ItemID.FragmentVortex, 3).AddIngredient(ItemID.SoulofLight, 20).AddIngredient(ItemID.SoulofNight, 20).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Lunatic Cultist (gold)
			Recipe.Create(ItemID.LunaticCultistMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.TwilightDye, 1).AddIngredient(ItemID.BossMaskCultist, 1).AddIngredient(ItemID.AncientCultistTrophy, 1).AddIngredient(ItemID.LunarCraftingStation, 1).AddIngredient(ItemID.FragmentNebula, 3).AddIngredient(ItemID.FragmentSolar, 3).AddIngredient(ItemID.FragmentStardust, 3).AddIngredient(ItemID.FragmentVortex, 3).AddIngredient(ItemID.SoulofLight, 20).AddIngredient(ItemID.SoulofNight, 20).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Lunatic Cultist (platinum)

			Recipe.Create(ItemID.MoonLordMasterTrophy).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.CelestialSigil, 1).AddIngredient(ItemID.LunarOre, 150).AddIngredient(ItemID.PortalGun, 1).AddIngredient(ItemID.GoldenDelight, 1).AddIngredient(ItemID.BossMaskMoonlord, 1).AddIngredient(ItemID.MoonLordTrophy, 1).AddIngredient(ItemID.GravityGlobe, 1).AddIngredient(ItemID.SuspiciousLookingTentacle, 1).AddIngredient(ItemID.LongRainbowTrailWings, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Moon Lord (gold)
			Recipe.Create(ItemID.MoonLordMasterTrophy).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.CelestialSigil, 1).AddIngredient(ItemID.LunarOre, 150).AddIngredient(ItemID.PortalGun, 1).AddIngredient(ItemID.GoldenDelight, 1).AddIngredient(ItemID.BossMaskMoonlord, 1).AddIngredient(ItemID.MoonLordTrophy, 1).AddIngredient(ItemID.GravityGlobe, 1).AddIngredient(ItemID.SuspiciousLookingTentacle, 1).AddIngredient(ItemID.LongRainbowTrailWings, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Moon Lord (gold)

			// Event Recipes Start Here

			Recipe.Create(ItemID.DarkMageMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DD2PetGato, 1).AddIngredient(ItemID.DefenderMedal, 25).AddIngredient(ItemID.BossMaskDarkMage, 1).AddIngredient(ItemID.BossTrophyDarkmage).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Dark Mage, Old One's Army (gold)
			Recipe.Create(ItemID.DarkMageMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DD2PetGato, 1).AddIngredient(ItemID.DefenderMedal, 25).AddIngredient(ItemID.BossMaskDarkMage, 1).AddIngredient(ItemID.BossTrophyDarkmage).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Dark Mage, Old One's Army (platinum)

			Recipe.Create(ItemID.OgreMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DD2PetGhost, 1).AddIngredient(ItemID.DefenderMedal, 50).AddIngredient(ItemID.BossMaskOgre, 1).AddIngredient(ItemID.BossTrophyOgre).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Ogre, Old One's Army (gold)
			Recipe.Create(ItemID.OgreMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DD2PetGhost, 1).AddIngredient(ItemID.DefenderMedal, 50).AddIngredient(ItemID.BossMaskOgre, 1).AddIngredient(ItemID.BossTrophyOgre).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Ogre, Old One's Army (platinum)

			Recipe.Create(ItemID.BetsyMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DD2PetDragon, 1).AddIngredient(ItemID.BetsyWings, 1).AddIngredient(ItemID.DefenderMedal, 100).AddIngredient(ItemID.BossMaskBetsy, 1).AddIngredient(ItemID.BossTrophyBetsy).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Betsy, Old One's Army (gold)
			Recipe.Create(ItemID.BetsyMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DD2PetDragon, 1).AddIngredient(ItemID.BetsyWings, 1).AddIngredient(ItemID.DefenderMedal, 100).AddIngredient(ItemID.BossMaskBetsy, 1).AddIngredient(ItemID.BossTrophyBetsy).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Betsy, Old One's Army (platinum)

			Recipe.Create(ItemID.MourningWoodMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.PumpkinMoonMedallion, 1).AddIngredient(ItemID.SpookyWood, 500).AddIngredient(ItemID.MourningWoodTrophy, 5).AddIngredient(ItemID.WitchBroom, 3).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Mourning Wood, Pumpkin Moon (gold)
			Recipe.Create(ItemID.MourningWoodMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.PumpkinMoonMedallion, 1).AddIngredient(ItemID.SpookyWood, 500).AddIngredient(ItemID.MourningWoodTrophy, 5).AddIngredient(ItemID.WitchBroom, 3).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Mourning Wood, Pumpkin Moon (platinum)

			Recipe.Create(ItemID.PumpkingMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.PumpkinMoonMedallion, 1).AddIngredient(ItemID.SpookyWood, 999).AddIngredient(ItemID.PumpkingTrophy, 5).AddIngredient(ItemID.GoodieBag, 40).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Pumpking, Pumpkin Moon (gold)
			Recipe.Create(ItemID.PumpkingMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.PumpkinMoonMedallion, 1).AddIngredient(ItemID.SpookyWood, 999).AddIngredient(ItemID.PumpkingTrophy, 5).AddIngredient(ItemID.GoodieBag, 40).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Pumpking, Pumpkin Moon (platinum)

			Recipe.Create(ItemID.EverscreamMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.NaughtyPresent, 1).AddIngredient(ItemID.EverscreamTrophy, 3).AddIngredient(ItemID.GiantBow, 1).AddIngredient(ItemID.Present, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Everscream, Frost Moon (gold)
			Recipe.Create(ItemID.EverscreamMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.NaughtyPresent, 1).AddIngredient(ItemID.EverscreamTrophy, 3).AddIngredient(ItemID.GiantBow, 1).AddIngredient(ItemID.Present, 10).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Everscream, Frost Moon (platinum)

			Recipe.Create(ItemID.SantankMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.NaughtyPresent, 1).AddIngredient(ItemID.SantaNK1Trophy, 3).AddIngredient(ItemID.GiantBow, 1).AddIngredient(ItemID.Present, 20).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //SantaNK1, Frost Moon (gold)
			Recipe.Create(ItemID.SantankMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.NaughtyPresent, 1).AddIngredient(ItemID.SantaNK1Trophy, 3).AddIngredient(ItemID.GiantBow, 1).AddIngredient(ItemID.Present, 20).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //SantaNK1, Frost Moon (platinum)

			Recipe.Create(ItemID.IceQueenMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.NaughtyPresent, 1).AddIngredient(ItemID.IceQueenTrophy, 3).AddIngredient(ItemID.ReindeerBells, 1).AddIngredient(ItemID.Present, 40).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Ice Queen, Frost Moon (gold)
			Recipe.Create(ItemID.IceQueenMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.NaughtyPresent, 1).AddIngredient(ItemID.IceQueenTrophy, 3).AddIngredient(ItemID.ReindeerBells, 1).AddIngredient(ItemID.Present, 40).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Ice Queen, Frost Moon (platinum)

			Recipe.Create(ItemID.FlyingDutchmanMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.PirateMap, 1).AddIngredient(ItemID.FlyingDutchmanTrophy, 1).AddIngredient(ItemID.PirateMinecart, 1).AddIngredient(ItemID.Cutlass, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Flying Dutchman, Pirate Invasion (gold)
			Recipe.Create(ItemID.FlyingDutchmanMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.PirateMap, 1).AddIngredient(ItemID.FlyingDutchmanTrophy, 1).AddIngredient(ItemID.PirateMinecart, 1).AddIngredient(ItemID.Cutlass, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Flying Dutchman, Pirate Invasion (platinum)

			Recipe.Create(ItemID.UFOMasterTrophy, 1).AddIngredient(ItemID.GoldBar, 25).AddIngredient(ItemID.MartianConduitPlating, 250).AddIngredient(ItemID.MartianSaucerTrophy, 1).AddIngredient(ItemID.ChargedBlasterCannon, 1).AddIngredient(ItemID.LaserDrill, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Martian Saucer, Martian Madness (gold)
			Recipe.Create(ItemID.UFOMasterTrophy, 1).AddIngredient(ItemID.PlatinumBar, 25).AddIngredient(ItemID.MartianConduitPlating, 250).AddIngredient(ItemID.MartianSaucerTrophy, 1).AddIngredient(ItemID.ChargedBlasterCannon, 1).AddIngredient(ItemID.LaserDrill, 1).AddIngredient(ItemID.GoldCoin, 10).AddTile(TileID.DemonAltar).AddTile(TileID.Anvils).Register(); //Martian Saucer, Martian Madness (platinum)

			#endregion Vanilla Master Mode Relics

		}
		public override void PostAddRecipes()/* tModPorter Note: Removed. Use ModSystem.PostAddRecipes */
		{
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				Recipe recipe = Main.recipe[i];

			}
		}
	}
}