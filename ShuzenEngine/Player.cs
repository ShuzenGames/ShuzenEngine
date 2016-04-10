using Microsoft.Xna.Framework;

namespace ShuzenEngine
{
    abstract class Player
    {
        public abstract void Update(GameTime gt);

        public abstract void Respawn(Vector2 pos);
    }
}
