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

			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = ItemUseStyleID.Swing;

			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;

			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
	}
}