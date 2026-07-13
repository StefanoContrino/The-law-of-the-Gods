using Terraria;
using Terraria.ModLoader;

namespace TheLawOfTheGods
{
    public class IntroPlayer : ModPlayer
    {

        public override void PreUpdate()
        {
            if(CutsceneManager.Active)
            {
                Player.controlLeft = false;
                Player.controlRight = false;
                Player.controlJump = false;
                Player.controlUseItem = false;
            }
        }

    }
}