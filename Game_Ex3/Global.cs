using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_Ex3
{
    class Global
    {
        public static ContentManager _Content;
        private static TextureManagement _TextureManagement = new TextureManagement();
        private static EffectManagement _EffectManagement = new EffectManagement();
        private static string _FX_NAME = "aEffect";

        public static void LoadTexture(string strResourceName)
        {
            _TextureManagement.LoadTexture(_Content, strResourceName);
        }

        public static void LoadEffect()
        {
            _EffectManagement.AddEffect(_Content, _FX_NAME);
        }

        public static void UpdateEntityVisible(GameTime gameTime)
        {
            _TextureManagement.UpdateTexture(gameTime);
        }

        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            _TextureManagement.DrawTexture(gameTime, spriteBatch);
        }

        public static Effect GetEffect()
        {
            return _EffectManagement.GetEffect(_FX_NAME);
        }
    }
}
