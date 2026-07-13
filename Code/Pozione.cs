using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Content.Items.Consumables
{
    public class Pozione : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useTime = 17;
            Item.useAnimation = 17;

            Item.UseSound = SoundID.Item3;

            Item.consumable = true;

            Item.maxStack = 99;

            Item.rare = ItemRarityID.Blue;

            Item.healLife = 50;
            Item.potion = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Daybloom)
                .AddTile(TileID.Bottles)
                .Register();
        }
    }
}
