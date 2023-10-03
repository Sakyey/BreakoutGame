using BreakoutGame;
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
        public int maximumX;
        public int maximumY;
        public int colWall = 0;
        public int colBrick = 0;
        public Rectangle brickRec;
        //Vector2 bollPos;
        Vector2 velocity;

        int ballX = 500;
        int ballY = 500;
        public Boll(SpriteBatch spriteBatch, Texture2D bollen, int wX, int wY)
        {
            _spriteBatch = spriteBatch;
            bollTex = bollen;
            bollPos = new Vector2(ballX, ballY);
            velocity = new Vector2(randXVel.Next(2, 9), randYVel.Next(-7, 0));
            bollRec = new Rectangle((int)bollPos.X, (int)bollPos.Y, bollen.Width,bollen.Height);
            //crash = false;
            maximumX = wX;
            maximumY = wY;
            changeDir = false;
        }
        public Rectangle BollHitBox() { return bollRec; }
        public void Update()
        {
            bollPos += velocity;
            
            //bollPos.X = bollPos.X + bollDir.X;
            //bollPos.Y = bollPos.Y + bollDir.Y;
            crash = false;

            
             if (bollPos.X > maximumX-30 || bollPos.X < 0)
             {
                velocity.X = velocity.X * -1;
                changeDir = true;
                colWall++;
             }

             if (bollPos.Y > maximumY-30 || bollPos.Y < 0)
             {
                velocity.Y = velocity.Y * -1;
                changeDir = true;
                colWall++;
             }
             
           
            
        }
        public void Reverse()
        {
            crash= true;
            velocity.Y = velocity.Y * 1;
        }
        public void Draw()
        {
            _spriteBatch.Draw(bollTex, bollPos, Color.Yellow);
        }
        public void CheckCrash(Rectangle bricks)
        {
            brickRec = bricks;
            if (bollRec.Intersects(brickRec))
            {
                crash = true;
                velocity.Y = velocity.Y * -1;
               
                //if (bollPos.X < maximumX && bollPos.X > 0)
                //{

                //    changeDir = false;
                //}
                //else
                //{
                //    velocity.X = velocity.X * -1;
                //    changeDir = true;
                //}
                //if (bollPos.Y > maximumY && bollPos.Y < 0)
                //{

                //    changeDir = false;
                //}
                //else
                //{
                //    velocity.Y = velocity.Y * -1;
                //    changeDir = true;
                //}




            }
        }
    }
}

