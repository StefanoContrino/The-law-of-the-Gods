using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLawOfTheGods.Content.Items
{
	public class TheJewsBlood : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 10000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;

			Item.useTime = 10;
			Item.useAnimation = 40;
			Item.useStyle = ItemUseStyleID.Swing;

			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;

			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();

			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);

			recipe.Register();
		}
	}
}