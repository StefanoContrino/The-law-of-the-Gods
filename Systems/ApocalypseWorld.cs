using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace TheLawOfTheGods
{
    public class ApocalypseWorld : ModSystem
    {
        public static bool IntroCompleted;


        public override void SaveWorldData(TagCompound tag)
        {
            tag["IntroCompleted"] = IntroCompleted;
        }


        public override void LoadWorldData(TagCompound tag)
        {
            IntroCompleted =
                tag.ContainsKey("IntroCompleted") &&
                tag.GetBool("IntroCompleted");
        }


        public override void OnWorldLoad()
        {
            IntroCompleted = false;
        }
    }
}