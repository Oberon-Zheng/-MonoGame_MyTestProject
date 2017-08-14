using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

//GameScreen:界面资源总类
//[基类(Base)] [资源类(Resource)]
//作用:用以派生出其他类型的界面资源


namespace Game1
{
    class GameScreen
    {
        protected ContentManager Content;
        public Type type;

        public GameScreen()
        {
            type = GetType();
        }

        public virtual void LoadContent()
        {
            Content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content");

        }

        public virtual void UnloadContent()
        {
            Content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
