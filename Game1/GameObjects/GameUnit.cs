using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameObjects
{
    public partial class GameUnit
    {
        private Party party1;

        public virtual Party Party1 { get => party1; set => party1 = value; }

        public virtual void LoadContent()
        {

        }

        public virtual void UnloadContent()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }
    }
}
