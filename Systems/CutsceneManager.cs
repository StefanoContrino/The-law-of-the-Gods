using Microsoft.Xna.Framework;
using Terraria;

namespace TheLawOfTheGods
{
    public static class CutsceneManager
    {
        public static bool Active;

        private static int timer;


        public static void StartIntro()
        {
            if(Active)
                return;


            Active = true;
            timer = 0;
        }


        public static void Update()
        {
            if(!Active)
                return;


            timer++;


            if(timer == 60)
            {
                Main.NewText(
                    "Guida: Sono passati mille anni dalla fine del mondo.",
                    Color.Yellow
                );
            }


            if(timer == 240)
            {
                Main.NewText(
                    "Guida: Il male ha divorato ogni cosa.",
                    Color.Yellow
                );
            }


            if(timer == 420)
            {
                Main.NewText(
                    "Guida: Ma tu sei ancora qui.",
                    Color.Yellow
                );
            }


            if(timer >= 600)
            {
                EndIntro();
            }
        }


        private static void EndIntro()
        {
            Active = false;
            ApocalypseWorld.IntroCompleted = true;


            Main.NewText(
                "La tua storia ha inizio.",
                Color.White
            );
        }
    }
}