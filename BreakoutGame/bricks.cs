using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakoutGame
{
    public class Bricks
    {
       public SpriteBatch _spriteBatch;
       public Texture2D _block;
       public Vector2 pos;
       public Rectangle bricks;
       public bool IsVisible;

            int brickX = 50;
            int brickY = 50;
            int brickWidth = 25;
            int brickHeight = 10;

        public Bricks(SpriteBatch spriteBatch, Texture2D block)
        {
            _spriteBatch = spriteBatch;
            _block= block;
            pos = Vector2.Zero;
            SetBrickSize();
            IsVisible = true;
        }
        public void SetBrickSize()
        {
            Rectangle bricks = new Rectangle(brickX, brickY, brickWidth, brickHeight);

        }
        public void SetBrickPos(int x, int y)
        {
            brickX = x;
            brickY = y;
            SetBrickSize();
        }
        public void Draw()
        {
            _spriteBatch.Draw(_block, bricks, Color.White);

        }
        public void Update()
        {

        }
  
        
    }
}
