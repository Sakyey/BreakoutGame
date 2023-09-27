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
        SpriteBatch spriteBatch;
        public Texture2D bollTex;
        public Vector2 bollPos;
        //public Vector2 bollDir;
        //public Vector2 bollSpeed;
        //public Rectangle bollRec;
        //public bool crash;
        //public bool changeDir;
        //public int maximumX = 800;
        //public int maximumY = -600;
        //public int minimumX = 0;
        //public int minimumY = 0;
            //Vector2 bollPos;
            Vector2 velocity;

        int ballX = 500;
        int ballY = 500;
        public Boll(SpriteBatch _spriteBatch, Texture2D bollen)
        {
            spriteBatch = _spriteBatch;
            bollTex = bollen;
            bollPos = new Vector2(ballX, ballY);
            velocity = new Vector2(0, 5);
            //this.bollTex = bollTex;
            //this.bollPos = bollPos;
            //bollRec = new Rectangle((int)bollPos.X, (int)bollPos.Y, 50, 50);
            //crash = false;
            //bollDir = new Vector2(7, -4);
            //changeDir = false;
        }
        public void Update()
        {
            bollPos += velocity;
            //bollPos.X = bollPos.X + bollDir.X;
            //bollPos.Y = bollPos.Y + bollDir.Y;
        }
        public void Draw()
        {
            spriteBatch.Draw(bollTex, bollPos, Color.Yellow);
        }
        //public void CheckCrash(Rectangle other)
        //{
        //    if (bollRec.Intersects(block))
        //    {
        //        crash = true;
        //        if (bollPos.X < maximumX && bollPos.X > minimumX)
        //        {
        //            changeDir = false;
        //        }
        //        else
        //        {
        //            bollDir.X = bollDir.X * -1;
        //            changeDir = true;
        //        }
        //        if (bollPos.Y > maximumY && bollPos.Y < minimumY)
        //        {
        //            changeDir = false;
        //        }
        //        else
        //        {
        //            bollDir.Y = bollDir.Y * -1;
        //            changeDir = true;
        //        }

            //}
    }
}