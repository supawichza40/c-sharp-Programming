using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algorithm_Visualizer_App
{
    interface ISortEngine
    {

        void DoWork(int[] arrayOfNumber_in, Graphics g_in, int max_value_in,float numberOfPixel_in,int graphicDelay_in);
        void  DisplayGraphic(int index,int anotherIndex);
    }
}
