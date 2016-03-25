using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    class Button : UI_Base
    {
        public string Text { get; set; }
        public SpriteFont Font { get; set; }
        public Texture2D Texture { get; set; }

        public Button()
        {
            IsEnabled = true;
            IsVisible = true;
            Width = 32;
            Hight = 24;
            Font = StandardPropertys.Font;
            Texture = StandardPropertys.BtnTexture;
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(Texture, new Rectangle(Position.ToPoint(), new Point(Width, Hight)), Color.White);
        }

        public override void Unload()
        {
            Font = null;
            Text = null;
            Texture = null;
        }

        public override void Update(GameTime gt)
        {
            throw new NotImplementedException();
        }
    }
}
