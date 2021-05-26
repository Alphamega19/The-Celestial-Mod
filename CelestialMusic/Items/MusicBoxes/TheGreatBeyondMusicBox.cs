using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace CelestialMusic.Items.MusicBoxes
{
	public class TheGreatBeyondMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
		    DisplayName.SetDefault("Music Box (The Great Beyond)");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.width = 30;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.rare = 0;
			item.value = 00010000;
			item.accessory = true;
			item.createTile = TileType<Tiles.MusicBoxes.TheGreatBeyondMusicBoxTile>();
		}

        public override void AddRecipes()
        {
            Mod CelestialMod = ModLoader.GetMod("Celestial");
            if (CelestialMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.FallenStar, 10);
                recipe.AddIngredient(ItemID.SunplateBlock, 50);
                recipe.AddIngredient(mod.ItemType("AncientMetal"), 10);
                recipe.AddIngredient(mod.ItemType("ColaxCrystal"), 5);
                recipe.AddTile(TileID.SkyMill);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}