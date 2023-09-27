using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout134
{
    public class Boll
    {
        SpriteBatch _spriteBatch;
        public Texture2D bollTex;
        public Vector2 bollPos;
        Random randXVel = new Random();
        Random randYVel = new Random();
        //public Vector2 bollDir;
        //public Vector2 bollSpeed;
        public Rectangle bollRec;
        public bool crash;
        public bool changeDir;
        public int maximumX = 1280;
        public int maximumY = -720;
        public int minimumX = 0;
        public int minimumY = 0;
        //Vector2 bollPos;
        Vector2 velocity;

        int ballX = 500;
        int ballY = 500;
        public Boll(SpriteBatch spriteBatch, Texture2D bollen)
        {
            _spriteBatch = spriteBatch;
            bollTex = bollen;
            bollPos = new Vector2(ballX, ballY);
            velocity = new Vector2(randXVel.Next(2, 7), randYVel.Next(-7, -2));
            //this.bollTex = bollTex;
            //this.bollPos = bollPos;
            bollRec = new Rectangle((int)bollPos.X, (int)bollPos.Y, 32, 32);
            //crash = false;
            //bollDir = new Vector2(7, -4);
            changeDir = false;
        }
        public void Update()
        {
            bollPos += velocity;
            //bollPos.X = bollPos.X + bollDir.X;
            //bollPos.Y = bollPos.Y + bollDir.Y;
        }
        public void Draw()
        {
            _spriteBatch.Draw(bollTex, bollPos, Color.Yellow);
        }
        public void CheckCrash(Rectangle bricks)
        {
            if (bollRec.Intersects(bricks))
            {
                crash = true;
                if (bollPos.X < maximumX && bollPos.X > minimumX)
                {
                    changeDir = false;
                }
                else
                {
                    velocity.X = velocity.X * -1;
                    changeDir = true;
                }
                if (bollPos.Y > maximumY && bollPos.Y < minimumY)
                {
                    changeDir = false;
                }
                else
                {
                    velocity.Y = velocity.Y * -1;
                    changeDir = true;
                }

            }
        }
    }
}