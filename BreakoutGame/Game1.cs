using BreakoutGame;
using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Breakout134
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public enum GameState
        {
            GameMenu = 0,
            GamePlaying = 1,
            GamePaused = 2,
            GameOver = 3,
            PlayingwPadle = 4,
            PlayingwKey = 5,
        }
        GameState currentGameState = GameState.GamePlaying;
        //Int list
        int boxWidth = 1280;
        int boxHeight = 720;
        int score = 0;
        int timeLeft;
        int highscore;
        int lives = 3;
        int numRows = 8;
        int numCols = 14;
        double frameTimer;

        //Texture list
        Texture2D colorblock;
        Texture2D bollen;
        Texture2D padle;
        Texture2D texture;
        Texture2D block;

        //Vector list
        Vector2 bollPos;
        Vector2 bollDir;
        Vector2 scorePos;

        //"Hitbox" list
        Rectangle bollRec;
        Rectangle blockRec;
        Rectangle padleRec;
        Rectangle gameOverRec;
        
        //Getting the mousestate for following the padle
        MouseState mouseState;
        Vector2 mousePos;
       

        //Calling the classes
        Boll boll1;
        Bricks bricks1;
        Padle padle1;
        bool resetBall;

        //List for storing and drawing the blocks
        List<Texture2D> block1;
        List<Texture2D> block2 = new List<Texture2D>();
        List<Texture2D> block3 = new List<Texture2D>();
        Bricks[,] brickArray;
        
        public Game1()
        {
            
           
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            //Changing the window size
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
            Texture2D bollTex = Content.Load<Texture2D>("ball_breakout");
            Vector2 bollPos = new Vector2(50, 50);

            Texture2D colorblockTex = Content.Load<Texture2D>("block_breakout");
            Rectangle blockRec = new Rectangle(0,0,colorblockTex.Width, colorblockTex.Height);

            Texture2D padleTex = Content.Load<Texture2D>("padle");
            Rectangle padleRec = new Rectangle();

            Vector2 bollDir = new Vector2(5, -5);
            Vector2 scorePos = new Vector2(50, 50);
            boll1 = new Boll(_spriteBatch, bollTex, boxWidth, boxHeight);
            padle1 = new Padle(padleTex);
            bricks1 = new Bricks(_spriteBatch, colorblockTex);
          

            brickArray = new Bricks[numCols,numRows];

            for (int i = 0; i < brickArray.GetLength(0); i++)
            {
                int x = 0;
                int y = i * 50;


             
              for (int j = 0; j < brickArray.GetLength(1); j++)
              {
                    x = 0;
                    y = j * 50;
                    brickArray[i, j] = new Bricks(_spriteBatch, colorblockTex);
              }

            }


        }

        protected override void Update(GameTime gameTime)
        {
            Rectangle padleHitbox = padle1.PadleHitBox();
            Rectangle bollHitBox = boll1.BollHitBox();
            if (bollHitBox.Contains(padleHitbox))
            {
                boll1.Reverse();
            }
            //frameTimer = gameTime.ElapsedGameTime.TotalMilliseconds;
            //if (frameTimer <= 0)
            //{

            //}
            //switch (currentGameState)
            //{
            //    case GameState.GameMenu: 
            //        Update.GameMenu(gameTime);
            //        break;
            //    case GameState.GamePlaying:
            //        Update.GamePlaying(gameTime);
            //    case
            //}
            boll1.Update();
            bricks1.Update();
            padle1.Update();
            boll1.CheckCrash(padleRec);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            for (int i = 0; i < numCols; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    Bricks brick = brickArray[i, j];
                    if (brick.IsActive)
                    {
                        brick.Draw(_spriteBatch);
                    }
                }
            }
            //bricks1.Draw();
            
            //bricks1.Draw();
            boll1.Draw();
            padle1.Draw(_spriteBatch);

            _spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

    }
}
