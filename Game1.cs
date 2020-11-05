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

        Texture2D bushTexture;
        Circle bushCircle;

        Texture2D bushDrawTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
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
            resetButtonCircle = new Circle(new Vector2(50, 50), 50f);
            
            bushTexture = Content.Load<Texture2D>("circle_bush");
            bushDrawTexture = bushTexture;
            bushCircle = new Circle(new Vector2(400, 240), 75);

            fireTexture = Content.Load<Texture2D>("fire");
         


        }

        protected override void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            fireBallCircle.Center = mouseState.Position.ToVector2();

            if (fireBallCircle.Intersects(bushCircle))
                bushDrawTexture = fireTexture;

            if (fireBallCircle.Contains(resetButtonCircle) && mouseState.LeftButton == ButtonState.Pressed)
                bushDrawTexture = bushTexture;


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(resetButtonTexture, resetButtonCircle.DrawRect, Color.White);
            _spriteBatch.Draw(bushDrawTexture, bushCircle.DrawRect, Color.White);
            _spriteBatch.Draw(fireballTexture, fireBallCircle.DrawRect, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
