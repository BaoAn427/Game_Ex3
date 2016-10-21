using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game_Ex3
{
    public class ModelSprite2D : Model
    {
        private string _Name;
        private List<Texture2D> _lTexture;    // List of Texture
        private int _nTexture;               // Length of List of Texture
        private int _iTexture;               // Pointer for element in List of Texture
        private float _Left;
        private float _Top;
        private float _Width;
        private float _Height;
        private float _Depth;
        private float _Scale;
        private float _DELAY = 80;


        public ModelSprite2D() { }

        public ModelSprite2D(string name, List<Texture2D> lTexture, float left, float top, float width, float height, float scale, float depth)
        {
            _Name = name;

            _lTexture = lTexture;
            _nTexture = _lTexture.Count;
            _iTexture = 0;

            _Left = left;
            _Top = top;


            if (width == 0)
                _Width = _lTexture[0].Width;
            else
                _Width = width;

            if (height == 0)
                _Height = _lTexture[0].Height;
            else
                _Height = height;

            if (scale < 0 || scale > 1.0f)
                _Scale = 1.0f;
            else
                _Scale = scale;

            if (depth < 0 || depth > 1)
                _Depth = 0;
            else
                _Depth = depth;
        }



        public override void Update(GameTime gameTime)
        {
            _iTexture = ((int)(gameTime.TotalGameTime.TotalMilliseconds / _DELAY)) % _nTexture;
        }


        public override void Draw(GameTime gameTime, object helper)
        {
            SpriteBatch spriteBatch = (SpriteBatch)helper;
            spriteBatch.Draw(_lTexture[_iTexture], new Vector2(_Left, _Top), null, Color.White, 0f, Vector2.Zero, _Scale, SpriteEffects.None, _Depth);
        }

    }
}
