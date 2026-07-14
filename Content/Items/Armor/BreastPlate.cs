using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLawOfTheGods.Content.Items.Armor
{
    // [AutoloadEquip(EquipType.Body)]
    public class BreastPlate : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Nome visualizzato in gioco
            ItemID.Sets.AnimatesAsSoul[Type] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.sellPrice(
                gold: 1
            );

            Item.rare = ItemRarityID.Blue;

            Item.defense = 5; // Difesa del corpetto
        }

        public override void UpdateEquip(Player player)
        {
            // Bonus quando viene indossato
            player.statManaMax2 += 20; // +20 mana massimo

            // Esempi:
            // player.statLifeMax2 += 20; // +20 vita
            // player.GetDamage(DamageClass.Melee) += 0.05f; // +5% danno melee
            // player.moveSpeed += 0.1f; // +10% velocità
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Silk, 5);

            recipe.AddTile(TileID.Anvils);

            recipe.Register();
        }
    }
}