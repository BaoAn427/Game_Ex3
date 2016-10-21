using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_Ex3
{
    class EffectManagement : GameEntity
    {
        private Dictionary<string, Effect> _lEffect = new Dictionary<string, Effect>();

        public void AddEffect(ContentManager content, string fxName)
        {
            Effect fx = content.Load<Effect>(fxName);
            if(!_lEffect.ContainsKey(fxName))
                _lEffect.Add(fxName, fx);            
        }

        public void LoadTechnique(string fxName, string techName)
        {
            Effect fx = _lEffect[fxName];
            if(fx != null)
                fx.CurrentTechnique = fx.Techniques[techName];
        }

        public Effect GetEffect(string fxName)
        {
            if (_lEffect.ContainsKey(fxName))
                return _lEffect[fxName];
            return null;
        }

        //public void SettingsForEffect(string fxName, string parameter, object value)
        //{
        //    Effect fx = _lEffect[fxName];
        //    if (fx != null)
        //    {
        //        fx.Parameters[parameter].SetValue(value);
        //    }
        //}
    }
}
