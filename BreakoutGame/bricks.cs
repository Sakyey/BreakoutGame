using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace BreakoutGame
{
    public class Bricks
    {
        public bool IsActive { get; set; }
       public SpriteBatch _spriteBatch;
       public Texture2D _block;
       public Vector2 pos;
       public Rectangle bricks;
       public bool IsVisible;

            int brickX = 50;
            int brickY = -50;
            int brickWidth = 25;
            int brickHeight = 10;

        public Bricks(SpriteBatch spriteBatch, Texture2D colorblockTex)
        {
            _spriteBatch = spriteBatch;
            _block= colorblockTex;
            pos = Vector2.Zero;
            SetBrickSize();
            IsActive = true; ;
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
        public void Update()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsActive)
            {
            _spriteBatch.Draw(_block, pos, Color.Red);

            }
            

        }
  
        
    }
}
