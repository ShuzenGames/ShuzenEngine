using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    public class SplashScreen : GameScreen
    {
        public int Timer { get; set; } //Standart 5 Sekunden pro Bild
        public const int TIME_FACTOR = 60;
        public List<Texture2D> Splashes { get; private set; }
        public bool Skipable { get; set; }
        public bool Done { get; private set; }
        private int currendTimer, count;

        public SplashScreen()
        {
            Timer = 5;
            currendTimer = 0;
            count = 0;
            Skipable = true;
            Splashes = new List<Texture2D>();
        }

        public void Init(params string[] fileNames)
        {
            foreach (string fileName in fileNames)
            {
                Splashes.Add(screenContent.Load<Texture2D>(fileName));
            }
        }

        public void Init(int timer, params string[] fileNames)
        {
            Timer = timer;
            foreach(string fileName in fileNames)
            {
                Splashes.Add(screenContent.Load<Texture2D>(fileName));
            }
        }

        public override void LoadContent(ContentManager content)
        {
            screenContent = content;
        }

        public override void UnloadContent()
        {
            Splashes = null;
        }

        public override void Update(GameTime gt)
        {
            if(currendTimer == Timer * TIME_FACTOR)
            {
                if(count < Splashes.Count)
                {
                    currendTimer = 0;
                    count++;
                }
                else
                {
                    Done = true;
                }
            }
            currendTimer++;
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(Splashes[count], new Rectangle(0, 0, (int)ScreenManager.Instance.ScreenDimension.X, (int)ScreenManager.Instance.ScreenDimension.Y), Color.White);
        }
    }
}
