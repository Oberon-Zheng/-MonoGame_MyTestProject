using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.GameObjects;

namespace Game1
{
    public static class PixCollision
    {
        public static bool PixelIntersection(GameObject objA,GameObject objB)
        {
            Rectangle rectIntersect = Rectangle.Intersect(objA.Rect, objB.Rect);

            
        }

        public static bool PixelIntersection(Rectangle rectA,Texture2D texA,Rectangle rectB,Texture2D texB)
        {
            Rectangle rectIntersect = Rectangle.Intersect(rectA, rectB);
            if(rectIntersect.IsEmpty)
            {
                return false;
            }
            else
            {
                Color[,] dataA = new Color[texA.Width, texA.Height];
                Color[,] dataB = new Color[texB.Width, texB.Height];
                for(int i = rectIntersect.X;i < rectIntersect.Width+rectIntersect.X;i++)
                {
                    for (int j = rectIntersect.Y; j < rectIntersect.Y+rectIntersect.Height; j++)
                    {
                        if(dataA[i,j].A!=0&&dataB[i,j].A!=0)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
