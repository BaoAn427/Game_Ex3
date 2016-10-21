using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Game_Ex3
{
    public class TextureManagement : GameEntity
    {
        //public ContentManager _Content;

        private List<EntityVisible> _lMapSrite = new List<EntityVisible>();

        public void LoadTexture(ContentManager content, string strResourceName)
        {
            List<Texture2D> lTexture = new List<Texture2D>();
            lTexture.Add(content.Load<Texture2D>(strResourceName));
            ModelSprite2D sprite = new ModelSprite2D(strResourceName, lTexture, 0, 0, 0, 0, -1, -1);
        }

        public void DrawTexture(GameTime gameTime, SpriteBatch spriteBatch)
        {
            int n = _lMapSrite.Count;
            for (int i = 0; i < n; ++i)
                _lMapSrite[i].Draw(gameTime, spriteBatch);
        }


        public void UpdateTexture(GameTime gameTime)
        {
            int n = _lMapSrite.Count;
            for (int i = 0; i < n; ++i)
                _lMapSrite[i].Update(gameTime);
        }
    }
}
