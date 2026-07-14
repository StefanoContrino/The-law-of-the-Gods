using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

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

			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.shoot = ModContent.ProjectileType<Projectiles.TheJewsBloodSlash>();
			Item.noUseGraphic = true;
		}


		public override bool Shoot(
			Player player,
			EntitySource_ItemUse_WithAmmo source,
			Vector2 position,
			Vector2 velocity,
			int type,
			int damage,
			float knockBack)
		{
			Projectile.NewProjectile(
				source,
				player.Center,
				velocity,
				type,
				damage,
				knockBack,
				player.whoAmI
			);

			return false;
		}
	}
}