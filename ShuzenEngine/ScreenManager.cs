using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ShuzenEngine
{
    public class ScreenManager
    {
        public ContentManager Content { get; private set; }
        public GameScreen currendScreen { get; private set; }
        public GameScreen[] gameScreens { get; private set; }
        public Vector2 ScreenDimension { get; private set; }
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
        }
        private static ScreenManager instance;

        private ScreenManager()
        {
            ScreenDimension = new Vector2(800, 600); //standart bildschirmauflösung
        }

        public void ChangeScreen(int index)
        {
            currendScreen.UnloadContent();
            currendScreen = null;
            currendScreen = gameScreens[index];
        }

        public void Init(GameScreen[] gameScreens)
        {
            this.gameScreens = gameScreens;
            currendScreen = gameScreens[0];
        }

        public void LoadContent(ContentManager content)
        {
            Content = new ContentManager(content.ServiceProvider, content.RootDirectory);
            currendScreen.LoadContent(Content);
        }

        public void UnloadContent()
        {
            Content.Dispose();
            currendScreen.UnloadContent();
        }

        public void Update(GameTime gt)
        {
            currendScreen.Update(gt);
        }

        public void Draw(SpriteBatch sb)
        {
            currendScreen.Draw(sb);
        }
    }
}
