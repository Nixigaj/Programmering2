using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spelprojekt.Background;
using Spelprojekt.Engine;
using Spelprojekt.Entities.Player;
using Spelprojekt.Gamestates;
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

        public static Gamestate gamestate = Gamestate.Alive;

        public static bool gamestate2Loaded = false;

        public Game1()
        {
            this.IsMouseVisible = true;

            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;   // set this value to the desired height of your window
            graphics.IsFullScreen = true;
            Window.AllowUserResizing = true;
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


            Gamestate1.LoadContent(Content);

            

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

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
            if (Keyboard.HasBeenPressed(Keys.F11))
            {
                if (graphics.IsFullScreen)
                {
                    graphics.IsFullScreen = false;
                    graphics.PreferredBackBufferWidth = 800;
                    graphics.PreferredBackBufferHeight = 600;
                }
                else
                {
                    graphics.IsFullScreen = true;
                    graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;  // set this value to the desired width of your window
                    graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
                } 
                graphics.ApplyChanges();
            }

            switch (gamestate)
            {
                case Gamestate.Alive: Gamestate1.Update(Window, Content, graphics, GraphicsDevice); return;
                case Gamestate.Dead:
                    if (!gamestate2Loaded)
                    {
                        Gamestate2.LoadContent(Content);
                        gamestate2Loaded = true;
                    }
                    Gamestate2.Update(Window, Content, graphics, GraphicsDevice);
                    return;
            }


            



            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {


            GraphicsDevice.Clear(Color.Aquamarine);


            switch (gamestate)
            {
                case Gamestate.Alive: Gamestate1.Draw(spriteBatch, GraphicsDevice); return;
                case Gamestate.Dead: Gamestate2.Draw(spriteBatch, GraphicsDevice); return;
            }

            

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }



        public enum Gamestate{ Alive, Dead }
    }
}
