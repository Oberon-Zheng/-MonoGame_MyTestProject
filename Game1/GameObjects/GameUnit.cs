using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Game1.GameObjects
{
    public partial class GameUnit : GameObject
    {
        private Party party1;

        public virtual Party Party1 { get => party1; set => party1 = value; }

        private float hp;
        private float pp;
        private float exp;
        private float lv;
        private float atk;
        private float def;
        private float spd;
        public float hpMax;
        public float ppMax;
        public float expMax;
        public float lvMax;
        public float atkStd;
        public float defStd;
        public float spdStd;

        
        
        public float Hp
        {
            get
            {
                return MathHelper.Clamp(hp, 0, hpMax);
            }
            set
            {
                hp = MathHelper.Clamp(value, 0, hpMax);
            }
        }
        public float Pp
        {
            get
            {
                return MathHelper.Clamp(pp, 0, ppMax);
            }
            set
            {
                pp = MathHelper.Clamp(value, 0, ppMax);
            }
        }
        public float Exp
        {
            get
            {
                return MathHelper.Clamp(exp, 0, expMax);
            }
            set
            {
                exp = MathHelper.Clamp(value, 0, expMax);
            }
        }
        public float Lv
        {
            get
            {
                return MathHelper.Clamp(lv, 0, lvMax);
            }
            set
            {
                exp = MathHelper.Clamp(value, 0, lvMax);
            }
        }

        public override void LoadContent()
        {

        }

        public override void UnloadContent()
        {

        }

        public override void Update()
        {

        }

        public override void Draw()
        {

        }
    }
}
