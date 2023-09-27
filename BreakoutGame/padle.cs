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
        SpriteBatch _spriteBatch;
        Texture2D padleTex;

        MouseState mouseState;
        Vector2 mousePos;
        public Padle(SpriteBatch spriteBatch, Texture2D padle)
        {
            padleTex = padle;
        }
        public void Update()
        {
            mouseState = Mouse.GetState();
            mousePos.X = mouseState.X - 73;
            mousePos.Y = 350;
        }
        public void Draw()
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(padleTex, mousePos, Color.Red);
            _spriteBatch.End();
        }

    }
}
