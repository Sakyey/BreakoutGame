using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakoutGame
{
    internal class Padle
    {
        Texture2D padleTex;
        Rectangle padleRec;
        Vector2 padlePosX;
        Vector2 padlePosY;
        MouseState mouseState;
        Vector2 mousePos;
        public bool holdingleft;
        public bool holdingright;

        public Padle(Texture2D padle)
        {
            this.padleTex = padle;
            mousePos = new Vector2();
            Rectangle padleRec = new Rectangle((int)mousePos.X, (int)mousePos.Y, padle.Width, padle.Height);
        }
        public Rectangle PadleHitBox() { return padleRec; }
        public void Update()
        {
            mouseState = Mouse.GetState();
            mousePos.X = mouseState.X - 73;
            mousePos.Y = 700;

            //KeyboardState ks = Keyboard.GetState();
            //if (ks.IsKeyDown(Keys.Left))
            //{
            //    padleRec.X -= (int)padleSpeed.X;
            //    holdingleft = true;
            //}
            //else if (ks.IsKeyDown(Keys.Right))
            //{
            //    padleRec.X += (int)padleSpeed.X;
            //    holdingright = true;
            //}

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(padleTex, mousePos, Color.Red);
        }

    }
}
