/*
 * KONTROLLER:
 * 
 * W: Framåt
 * A: Vänster
 * S: Bakåt
 * D: Höger
 * Mellanslag: Färdas snabbare
 * Vänster shift: Lämna svans efter dig
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceShooter
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D ship_texture;
        Vector2 ship_vector;
        Vector2 ship_speed;
        float boostValue;
        Color backgroundColor;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            this.IsMouseVisible = true;

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
            ship_vector.X = 380;
            ship_vector.Y = 400;
            ship_speed.X = 6.0f;
            ship_speed.Y = 6.0f;
            boostValue = 8.0f;
            backgroundColor = new Color(25 / 255.0f, 0 / 255.0f, 50 / 255.0f);
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

            ship_texture = Content.Load<Texture2D>("player/ship");

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            KeyboardState keyboardState = Keyboard.GetState();

            if (ship_vector.X <= Window.ClientBounds.Width - ship_texture.Width && ship_vector.X >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.D))
                {
                    if (keyboardState.IsKeyDown(Keys.Space)) ship_vector.X += ship_speed.X + boostValue;
                    else ship_vector.X += ship_speed.X;
                }
                if (keyboardState.IsKeyDown(Keys.A))
                {
                    if (keyboardState.IsKeyDown(Keys.Space)) ship_vector.X -= ship_speed.X + boostValue;
                    else ship_vector.X -= ship_speed.X;
                }
            }

            if (ship_vector.Y <= Window.ClientBounds.Height - ship_texture.Height && ship_vector.Y >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.S))
                {
                    if (keyboardState.IsKeyDown(Keys.Space)) ship_vector.Y += ship_speed.Y + boostValue;
                    else ship_vector.Y += ship_speed.Y;
                }
                if (keyboardState.IsKeyDown(Keys.W))
                {
                    if (keyboardState.IsKeyDown(Keys.Space)) ship_vector.Y -= ship_speed.Y + boostValue;
                    else ship_vector.Y -= ship_speed.Y;
                }
            }

            if (ship_vector.X < 0) ship_vector.X = 0;
            if (ship_vector.X > Window.ClientBounds.Width - ship_texture.Width) ship_vector.X = Window.ClientBounds.Width - ship_texture.Width;

            if (ship_vector.Y < 0) ship_vector.Y = 0;
            if (ship_vector.Y > Window.ClientBounds.Height - ship_texture.Height) ship_vector.Y = Window.ClientBounds.Height - ship_texture.Height;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {


            if (!Keyboard.GetState().IsKeyDown(Keys.LeftShift)) GraphicsDevice.Clear(backgroundColor);

            spriteBatch.Begin();   // Starta "bildUppritaren"
            spriteBatch.Draw(ship_texture, ship_vector, Color.White);
            spriteBatch.End();  // Stäng av "bildUppritaren"

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
