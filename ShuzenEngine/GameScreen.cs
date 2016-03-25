using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    public abstract class GameScreen
    {
        protected ContentManager screenContent;
        protected bool isOverlapping; //für menüs etc.

        public abstract void LoadContent(ContentManager content);

        public abstract void UnloadContent();

        public abstract void Update(GameTime gt);

        public abstract void Draw(SpriteBatch sb);
    }
}
