using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    public class SpriteMap
    {
        public Texture2D Sprite { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public bool Updating { get; set; }
        private int currentFrame;
        private int totalFrames;

        public SpriteMap(Texture2D texture)
        {
            Sprite = texture;
            totalFrames = 1;
        }

        public SpriteMap(Texture2D texture, int frames)
        {
            Sprite = texture;
            totalFrames = frames;
        }

        public void Update()
        {
            if (Updating)
            {
                currentFrame++;
                if (currentFrame == totalFrames)
                    currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch sb, Vector2 position)
        {
            int width = Sprite.Width / Columns;
            int height = Sprite.Height / Rows;
            int row = currentFrame / Columns;
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);

            sb.Draw(Sprite, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
