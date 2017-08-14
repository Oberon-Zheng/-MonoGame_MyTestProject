using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ScreenManager:界面管理器
//类型：单例类(Singleton)
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
        
        ScreenManager()
        {

        }


    }
}
