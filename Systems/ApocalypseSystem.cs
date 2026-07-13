using Terraria.ModLoader;

namespace TheLawOfTheGods
{
    public class ApocalypseSystem : ModSystem
    {
        public override void PostUpdateWorld()
        {
            CutsceneManager.Update();
        }
    }
}