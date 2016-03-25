using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    abstract class UI_Base
    {
        protected Vector2 Position { get; set; }
        protected bool IsVisible { get; set; }
        protected bool IsEnabled { get; set; }
        protected int Width { get; set; }
        protected int Hight { get; set; }

        public abstract void Unload();

        public abstract void Update(GameTime gt);

        public abstract void Draw(SpriteBatch sb);
    }
}