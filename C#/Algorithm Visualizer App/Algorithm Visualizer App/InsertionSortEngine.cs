using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualizer_App
{
    class InsertionSortEngine : ISortEngine
    {
        int[] arrayOfNumber;
        Graphics g;
        float numberOfPixel;
        int graphicDelay;
        private int max_value;
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        
        public void DisplayGraphic(int index, int anotherIndex)
        {
            g.FillRectangle(BlackBrush, index * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, anotherIndex * numberOfPixel, 0, numberOfPixel, max_value);

            g.FillRectangle(BlackBrush, index * numberOfPixel, max_value - arrayOfNumber[index], numberOfPixel, max_value);

            g.FillRectangle(BlackBrush, anotherIndex * numberOfPixel, max_value - arrayOfNumber[anotherIndex], numberOfPixel, max_value);

            g.FillRectangle(WhiteBrush, index * numberOfPixel, max_value - arrayOfNumber[index], numberOfPixel - 1, max_value - 1);
            g.FillRectangle(WhiteBrush, anotherIndex * numberOfPixel, max_value - arrayOfNumber[anotherIndex], numberOfPixel - 1, max_value - 1);
        }

        public void DoWork(int[] arrayOfNumber_in, Graphics g_in, int max_value_in, float numberOfPixel_in, int graphicDelay_in)
        {
            arrayOfNumber = arrayOfNumber_in;
            g = g_in;
            numberOfPixel = numberOfPixel_in;
            graphicDelay = graphicDelay_in;
            max_value = max_value_in;

            for (int i = 0; i < arrayOfNumber.Length-1; i++)
            {
                for (int j = i+1; j >0 ; j--)
                {
                    if (arrayOfNumber[j-1] >arrayOfNumber[j])
                    {
                        int temp = arrayOfNumber[j-1];
                        arrayOfNumber[j - 1] = arrayOfNumber[j];
                        arrayOfNumber[j] = temp;
                        DisplayGraphic(j, j - 1);
                        System.Threading.Thread.Sleep(graphicDelay);
                    }
                }
            }
            
        }
    }
}
