using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spelprojekt.Background;
using System;

namespace Spelprojekt
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        

        //Egna
        RecrusiveTexture back1;
        RecrusiveTexture back2;
        RecrusiveTexture back3;

        public Game1()
        {
            this.IsMouseVisible = true;

            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;   // set this value to the desired height of your window
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            /*
            Texture2D[] back = new Texture2D[1];
            Texture2D[] middle = new Texture2D[1];
            Texture2D[] front = new Texture2D[1];
            back[0] = Content.Load<Texture2D>("Textures/level1/background/back/1");
            middle[0] = Content.Load<Texture2D>("Textures/level1/background/middle/1");
            front[0] = Content.Load<Texture2D>("Textures/level1/background/front");
            */
            

            back1 = new RecrusiveTexture(Content.Load<Texture2D>("Textures/level1/background/back/1"), 0f, 0f, 100, 1);
            back2 = new RecrusiveTexture(Content.Load<Texture2D>("Textures/level1/background/middle/1"), 0f, 0f, 100, 1);
            back3 = new RecrusiveTexture(Content.Load<Texture2D>("Textures/level1/background/front"), 0f, 0f, 100, 1);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        float vary = 0;
        static float maxSpeed = 0.5f;
        float accelleration = 0.03f * maxSpeed;

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState keyboardState = Keyboard.GetState();

            if (!keyboardState.IsKeyDown(Keys.D) && !keyboardState.IsKeyDown(Keys.A))
            {
                if (Math.Abs(vary) < accelleration) vary = 0;
                else if (vary > 0) vary -= accelleration;
                else if (vary < 0) vary += accelleration;
            }
            else
            {
                if (keyboardState.IsKeyDown(Keys.A))
                {
                    if (vary < 0) vary += accelleration * 4;
                    else if (vary < maxSpeed) vary += accelleration * 2;
                    else if (vary > maxSpeed) vary = maxSpeed;
                }
                if (keyboardState.IsKeyDown(Keys.D))
                {
                    if (vary > 0) vary -= accelleration * 4;
                    else if (vary > -maxSpeed) vary -= accelleration * 2;
                    else if (vary < -maxSpeed) vary = -maxSpeed;
                }
            }
            
            

            back1.Move(10f*vary, 0f);
            back1.Move(12f * vary, 0f);
            back1.Move(18f * vary, 0f);





            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();   // Starta "bildUppritaren"
            back1.Draw(spriteBatch);
            back2.Draw(spriteBatch);
            back3.Draw(spriteBatch);
            spriteBatch.End();  // Stäng av "bildUppritaren"

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
