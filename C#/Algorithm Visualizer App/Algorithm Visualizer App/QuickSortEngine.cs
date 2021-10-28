using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;

namespace Algorithm_Visualizer_App
{
    class QuickSortEngine:ISortEngine
    {

        private int[] arrayOfNumber;

        private Graphics g;
        private int max_value;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush RedBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        private float numberOfPixel;
        private int graphicDelay;
        public void DoWork(int[] arrayOfNumber_in, Graphics g_in, int max_value_in,float numberOfpixel_in,int graphicDelay_in)
        {

            this.arrayOfNumber = arrayOfNumber_in;
            this.g = g_in;
            this.max_value = max_value_in;
            numberOfPixel = numberOfpixel_in;
            graphicDelay = graphicDelay_in;


            QuickSort(arrayOfNumber,0,arrayOfNumber.Length-1);







        }





        private void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }
        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int pivotIndex = end;
            int i = start - 1;
            //g.FillRectangle(RedBrush, pivotIndex, 0, 1, max_value);
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    DisplayGraphic(arr, i, j, pivotIndex);
                    System.Threading.Thread.Sleep(graphicDelay);
                }
            }

            DisplayGraphic(arr, pivotIndex);
            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            int k = end;
            DisplayGraphic(arr, i, k);

            System.Threading.Thread.Sleep(1);
            return i + 1;
        }

        public void DisplayGraphic(int[] arr,int i, int k)
        {
            g.FillRectangle(BlackBrush, (i + 1) * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, k * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, (i + 1) * numberOfPixel, max_value - arrayOfNumber[i + 1], numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, k * numberOfPixel, max_value - arrayOfNumber[k], numberOfPixel, max_value);
            g.FillRectangle(WhiteBrush, (i + 1) * numberOfPixel, max_value - arrayOfNumber[i + 1], numberOfPixel-1, max_value-1);
            g.FillRectangle(WhiteBrush, k * numberOfPixel, max_value - arrayOfNumber[k], numberOfPixel-1, max_value-1);
        }
        public void DisplayGraphic(int[] arr,int i, int j, int pivotIndex)
        {
            g.FillRectangle(BlackBrush, i * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, j * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(RedBrush, pivotIndex * numberOfPixel, max_value - arr[pivotIndex], numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, i * numberOfPixel, max_value - arrayOfNumber[i], numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, j * numberOfPixel, max_value - arrayOfNumber[j], numberOfPixel, max_value);
            g.FillRectangle(WhiteBrush, i * numberOfPixel, max_value - arrayOfNumber[i], numberOfPixel-1, max_value-1);
            g.FillRectangle(WhiteBrush, j * numberOfPixel, max_value - arrayOfNumber[j], numberOfPixel-1, max_value-1);


        }
        public void DisplayGraphic(int[] arr,int pivotIndex)
        {
            g.FillRectangle(BlackBrush, pivotIndex * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, pivotIndex * numberOfPixel, max_value - arrayOfNumber[pivotIndex], numberOfPixel, max_value);
            g.FillRectangle(WhiteBrush, pivotIndex * numberOfPixel, max_value - arrayOfNumber[pivotIndex], numberOfPixel-1, max_value-1);
        }

        public void DisplayGraphic(int index, int anotherIndex)
        {
            throw new NotImplementedException();
        }
    }

}
