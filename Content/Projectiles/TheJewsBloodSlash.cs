using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheLawOfTheGods.Content.Projectiles
{
	public class TheJewsBloodSlash : ModProjectile
	{
		public override string Texture =>
			"TheLawOfTheGods/Content/Projectiles/TheJewsBloodSlash";


		public override void SetStaticDefaults()
		{
			Main.projFrames[Type] = 4;
		}


		public override void SetDefaults()
		{
			Projectile.width = 32;
			Projectile.height = 32;

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


			Projectile.rotation =
				Projectile.velocity.ToRotation();


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