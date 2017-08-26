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
        
        private static void TexGetData2D(Texture2D tex,Color[,] container)
        {
            Color[] metaData = new Color[tex.Width*tex.Height];
            tex.GetData(metaData);
            for(int i = 0; i < tex.Height; i++)
            {
                for(int j = 0;j < tex.Width; j++)
                {
                    container[i, j] = metaData[i * tex.Width + j];
                }
            }
        }

        public static bool PixelIntersection(Rectangle rectA, Texture2D texA, Rectangle rectB, Texture2D texB,byte tolerance = 0)
        {
            Rectangle rectIntersect = Rectangle.Intersect(rectA, rectB);
            if (rectIntersect.IsEmpty)
            {
                return false;
            }
            else
            {
                Color[,] dataA = new Color[texA.Width, texA.Height];
                Color[,] dataB = new Color[texB.Width, texB.Height];
                TexGetData2D(texA, dataA);
                for (int i = rectIntersect.X; i < rectIntersect.Width + rectIntersect.X; i++)
                {
                    for (int j = rectIntersect.Y; j < rectIntersect.Y + rectIntersect.Height; j++)
                    {
                        if (dataA[i, j].A >= tolerance && dataB[i, j].A >= tolerance)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }


        /*private static bool CollisionDetection(Rectangle rectA, Color[] dataA, Rectangle rectB, Color[] dataB)
        {
            int top = Math.Max(rectA.Top, rectB.Top);
            int bottom = Math.Min(rectA.Bottom, rectB.Bottom);
            int left = Math.Max(rectA.Left, rectB.Left);
            int right = Math.Min(rectA.Right, rectB.Right);

            for (int i = top; i < bottom; i++)
            {
                for (int j = left; j < right; j++)
                {
                    Color a = dataA[(j - rectA.Left) + (i - rectA.Top) * objA.Width];
                    Color b = dataB[(j - rectB.Left) + (i - rectB.Top) * objB.Width];

                    if (a.A != 0 && b.A != 0)
                    {
                        //System.Diagnostics.Debug.WriteLine("{0}\t{1}",i,j);
                        return (true);
                    }
                }
            }

            return (false);
        }*/

        /*public static bool PixelIntersection(Rectangle rectA,Texture2D texA,Rectangle rectB,Texture2D texB)
        {
            Rectangle rInt = Rectangle.Intersect(rectA, rectB);

            Color[] dataA = new Color[texA.Width * texA.Height];
            Color[] dataB = new Color[texB.Width * texB.Height];

            for(int i = rInt.Top; i < rInt.Bottom; i++)
            {

                for(int j = rInt.Left; j < rInt.Right; j++)
                {
                    
                }
            }
        }*/

    }
}
