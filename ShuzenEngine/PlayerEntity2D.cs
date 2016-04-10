using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    class PlayerEntity2D : Entity2D
    {
        public PlayerEntity2D()
        {

        }

        public void Spawn(Vector2 pos)
        {
            Position = pos;
            Speed = Vector2.Zero;
            Acceleration = Vector2.Zero;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content); //Loading content in EntityContent
        }

        public override void Draw(SpriteBatch sb)
        {

        }

        public override void Update(GameTime gt)
        {
            
        }
    }
}
