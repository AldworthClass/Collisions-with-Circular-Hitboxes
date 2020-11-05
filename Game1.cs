using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Collisions_with_Circular_Hitboxes
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        MouseState mouseState;

        // Textures

        Texture2D fireballTexture;
        Circle fireBallCircle;

        Texture2D resetButtonTexture;
        Circle resetButtonCircle;

        Texture2D fireTexture;
        Circle fireCircle;

        Texture2D bushTexture;
        Circle bushCircle;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

           


        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();


        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            fireballTexture = Content.Load<Texture2D>("fireball");
            fireBallCircle = new Circle(new Vector2(0, 0), 25f);

            resetButtonTexture = Content.Load<Texture2D>("reset_button");
            resetButtonCircle = new Circle(new Vector2(100, 100), 100f);
            
            bushTexture = Content.Load<Texture2D>("circle_bush");
            bushCircle = new Circle(new Vector2(350, 200), 75);

            fireTexture = Content.Load<Texture2D>("fire");
            fireCircle = bushCircle;

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(resetButtonTexture, )

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
