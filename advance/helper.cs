using advance.Genaric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    internal class helper
    {
        public static void SWAP(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SWAP(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;



        }
        public static void SWAP(ref point x, ref point y)
        {
            point temp = x;
            x = y;
            y = temp;
        }


        /* public static void  SWAP<T>(ref T X, ref T Y)
         {
             T tem  = X;    
             X = Y;
               Y=tem;



         }*/
        /*public static int SearchArry<T>(int[] arry, int value)
          {
             if (arry is not null)
              {
                  for (int i = 0; i < arry.Length; i++)
                  {
                      if (value == arry[i])
                          return i;

                  }
                  return -1;

              }*/
        #region MyRegion

        public static void BubbleSort(int[] arry)
        {
            if (arry is not null)

            {
                for (int i = 0; i < arry.Length; i++)
                {
                    for (int K = 0; K < arry.Length - i - 1; K++)
                    {
                        if (arry[K] == arry[K + 1])
                            helper.SWAP<int>(ref arry[K], ref arry[K + 1]);

                    }

                }

            }




            #endregion



        }

        private static void SWAP<T>(ref T v1, ref T v2)
        {
            throw new NotImplementedException();
        }
    }  }  
  
