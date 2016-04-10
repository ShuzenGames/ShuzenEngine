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
    abstract class Entity2D : Entity
    {
        protected Vector2 Position { get; set; }
        protected Vector2 Speed { get; set; }
        protected Vector2 Acceleration { get; set; }
        protected Texture2D Sprite { get; set; }
        protected SpriteMap SpriteMap { get; set; }
    }
}
