using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheLawOfTheGods.Content.Items.Consumables
{
    public class RedApple : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 5;

            // Particelle quando viene mangiata
            ItemID.Sets.FoodParticleColors[Type] = new Color[]
            {
                new Color(255, 170, 40),
                new Color(255, 200, 80),
                new Color(255, 240, 180)
            };
        }

        public override void SetDefaults()
        {
            // Dimensioni dell'oggetto
            Item.width = 32;
            Item.height = 32;

            // Stack
            Item.maxStack = Item.CommonMaxStack;

            // Valore e rarità
            Item.value = Item.buyPrice(silver: 2);
            Item.rare = ItemRarityID.White;

            // Comportamento cibo
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.UseSound = SoundID.Item2;
            Item.consumable = true;

            // Buff
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 60 * 60 * 5;

            Item.noUseGraphic = false;

            Item.holdStyle = ItemHoldStyleID.HoldFront;
        }

        public override void HoldStyle(Player player, Rectangle heldItemFrame) {
            player.itemLocation.X += player.direction * -18;
            player.itemLocation.Y += 6;

            player.itemRotation = player.direction * 0.15f;

        } 

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Acorn)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}