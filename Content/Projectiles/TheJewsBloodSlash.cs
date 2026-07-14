using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

			Projectile.rotation = player.itemRotation;

			Projectile.spriteDirection = player.direction;


			Projectile.frameCounter++;

			if (Projectile.frameCounter >= 5)
			{
				Projectile.frameCounter = 0;
				Projectile.frame++;

				if (Projectile.frame >= 4)
					Projectile.frame = 0;
			}
		}


		public override bool PreDraw(ref Color lightColor)
		{
			Texture2D texture = ModContent.Request<Texture2D>(Texture).Value;


			Rectangle frame = new Rectangle(
				0,
				Projectile.frame * 32,
				32,
				32
			);


			Vector2 origin = frame.Size() / 2;


			Main.EntitySpriteDraw(
				texture,
				Projectile.Center - Main.screenPosition,
				frame,
				lightColor,
				Projectile.rotation,
				origin,
				1f,
				Projectile.spriteDirection == 1
					? SpriteEffects.None
					: SpriteEffects.FlipHorizontally,
				0
			);


			return false;
		}
	}
}