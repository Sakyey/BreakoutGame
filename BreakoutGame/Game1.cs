using BreakoutGame;
using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Breakout134
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        int boxHeight = 720;
        int boxWidth = 1280;
        int score = 0;
        int counter = 0;
        int highscore;
        int lives = 3;
        int numRows = 8;
        int numCols = 12;

        Texture2D colorblock;
        Texture2D bollen;
        Texture2D padle;
        Texture2D texture;
        Texture2D block;

        Vector2 bollPos;
        Vector2 bollDir;
        Vector2 scorePos;

        Rectangle bollRec;
        Rectangle blockRec;
        Rectangle padleRec;
        Rectangle gameOverRec;
        

        MouseState mouseState;
        Vector2 mousePos;
        Boll boll1;
        Bricks bricks1;
        Padle padle1;
        bool resetBall;
        List<Texture2D> block1 = new List<Texture2D>();
        List<Texture2D> block2 = new List<Texture2D>();
        List<Texture2D> block3 = new List<Texture2D>();
        
        public Game1()
        {
            
           
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;

            _graphics.PreferredBackBufferHeight = boxHeight;
            _graphics.PreferredBackBufferWidth = boxWidth;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D bollen = Content.Load<Texture2D>("ball_breakout");
            Vector2 bollPos = new Vector2(50, 50);
            Texture2D colorblock = Content.Load<Texture2D>("block_breakout");
            //Rectangle block = new Rectangle();
            Rectangle blockRec = new Rectangle(0,0,colorblock.Width, colorblock.Height);
            Texture2D padle = Content.Load<Texture2D>("padle");
            //Rectangle padleRec = new Rectangle();
            Vector2 bollDir = new Vector2(5, -5);
            Vector2 scorePos = new Vector2(50, 50);
            boll1 = new Boll(_spriteBatch, bollen);
            block1.Add(colorblock);
            
            //bollRec = new Rectangle((Window.ClientBounds.Width)

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            //bollPos.X = bollPos.X + bollDir.X;
            //bollPos.Y = bollPos.Y + bollDir.Y;

            boll1.Update();
            bricks1.Update();
            padle1.Update();
            //boll1.CheckCrash();
            //boll.CheckCrash(padle);
            // TODO: Add your update logic here
            //padle1.Update();
            //mouseState = Mouse.GetState();
            //mousePos.X = mouseState.X - 73;
            //mousePos.Y = 350;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            boll1.Draw();
            padle1.Draw();
            bricks1.Draw();

            _spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

    }
}
