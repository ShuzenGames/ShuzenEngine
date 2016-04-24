using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    abstract class Entity3D : Entity
    {
        protected Vector3 Position { get; set; } //for 3D Games
        protected Vector3 Speed { get; set; }
        protected Vector3 Acceleration { get; set; }
        protected Model Model { get; set; }

        public virtual void DrawModel()
        {

        }
    }
}
