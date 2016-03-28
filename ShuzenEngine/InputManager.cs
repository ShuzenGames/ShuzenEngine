using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShuzenEngine
{
    public class InputManager
    {
        private static InputManager instance;

        public InputMode inputMode { get; set; }
        public KeyboardState ks { get; private set; }
        public KeyboardState oldKS { get; private set; }
        public MouseState ms { get; private set; }
        public MouseState oldMS { get; private set; }
        public GamePadState ps { get; private set; }
        public GamePadState oldPS { get; private set; }
        public static InputManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new InputManager();
                }
                return instance;
            }
        }

        private InputManager()
        {
            inputMode = InputMode.KeyBoard;
            ks = Keyboard.GetState();
            ms = Mouse.GetState();
            ps = GamePad.GetState(PlayerIndex.One);
            oldKS = ks;
            oldMS = ms;
            oldPS = ps;
        }

        public void Update()
        {
            if (inputMode == InputMode.KeyBoard)
            {
                ks = Keyboard.GetState();
                ms = Mouse.GetState();
                oldKS = ks;
                oldMS = ms;
            }
            else if (inputMode == InputMode.GamePad)
            {
                ps = GamePad.GetState(PlayerIndex.One);
                oldPS = ps;
            }
        }
    }

    public enum InputMode
    {
        GamePad,
        KeyBoard
    }
}
