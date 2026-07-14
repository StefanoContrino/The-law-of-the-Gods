using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TheLawOfTheGods.Common.Players
{
	public class TheJewsBloodDrawLayer : PlayerDrawLayer
	{
		public override Position GetDefaultPosition()
		{
			return new BeforeParent(PlayerDrawLayers.HeldItem);
		}

		public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
		{
			return drawInfo.drawPlayer.HeldItem.type == ModContent.ItemType<Content.Items.TheJewsBlood>();
		}


		protected override void Draw(ref PlayerDrawSet drawInfo)
		{
			Player player = drawInfo.drawPlayer;

			if (player.itemAnimation <= 0)
				return;


			Texture2D texture = ModContent.Request<Texture2D>(
				"TheLawOfTheGods/Content/Items/TheJewsBlood"
			).Value;


			// Numero frame
			int frame = (int)(
				(1f - (float)player.itemAnimation / player.itemAnimationMax)
				* 4
			);


			if (frame < 0)
				frame = 0;

			if (frame > 3)
				frame = 3;


			Rectangle source = new Rectangle(
				0,
				frame * 32,
				32,
				32
			);


			Vector2 position = player.MountedCenter 
				- Main.screenPosition;


			DrawData data = new DrawData(
				texture,
				position,
				source,
				drawInfo.colorArmorBody,
				player.itemRotation,
				source.Size() / 2,
				1f,
				player.direction == 1 
					? SpriteEffects.None 
					: SpriteEffects.FlipHorizontally,
				0
			);


			drawInfo.DrawDataCache.Add(data);
		}
	}
}