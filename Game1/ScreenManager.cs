using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

//ScreenManager:界面管理器
//[单例类(Singleton)]
//作用：管理界面资源（GameScreen）的调度（装卸）、切换以及数据交流


namespace Game1
{
    class ScreenManager
    {
        private static ScreenManager instance;
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
            }
        }

        public ContentManager Content
        {
            private set;
            get;
        }

        GameScreen currScrn;
        GameScreen prevScrn = null;
        GameScreen nextScrn = null;

        public ScreenManager()
        {
            
        }

        public void LoadContent(ContentManager content)
        {
            this.Content = new ContentManager(content.ServiceProvider);
            if(currScrn != null)
            {
                currScrn.LoadContent();
            }
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
