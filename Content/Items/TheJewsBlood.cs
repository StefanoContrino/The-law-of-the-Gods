using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

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

			Item.shoot = ModContent.ProjectileType<TheJewsBloodProjectile>();
			Item.noUseGraphic = true;
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockBack)
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


	public class TheJewsBloodProjectile : ModProjectile
	{
		public override string Texture => "TheLawOfTheGods/Content/Items/TheJewsBloodProjectile";


		public override void SetStaticDefaults()
		{
			Main.projFrames[Type] = 4;
		}


		public override void SetDefaults()
		{
			Projectile.width = 32;
			Projectile.height = 32;

			Projectile.aiStyle = 0;

			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Melee;

			Projectile.penetrate = -1;

			Projectile.tileCollide = false;

			Projectile.timeLeft = 40;
		}


		public override void AI()
		{
			Player player = Main.player[Projectile.owner];

			Projectile.Center = player.Center;

			Projectile.rotation = Projectile.velocity.ToRotation();

			Projectile.frameCounter++;

			if (Projectile.frameCounter >= 5)
			{
				Projectile.frameCounter = 0;
				Projectile.frame++;

				if (Projectile.frame >= 4)
					Projectile.frame = 0;
			}
		}
	}
}