using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    class PlayerEntity3D : Entity3D
    {
        public PlayerEntity3D()
        {

        }

        public void Spawn(Vector3 pos)
        {
            Position = pos;
            Speed = Vector3.Zero;
            Acceleration = Vector3.Zero;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content); //Loading content in EntityContent
        }

        public override void Draw(SpriteBatch sb)
        {
            base.DrawModel();
        }

        public override void Update(GameTime gt)
        {
            base.Update(gt);
        }
    }
}
