using System.Drawing;
using System.Linq;

namespace Algorithm_Visualizer_App
{
    class BubbleSortEngine : ISortEngine
    {
        private bool _sorted = false;
        private int[] arrayOfNumber;
        private float numberOfPixel;
        private Graphics g;
        private int max_value;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush GreenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        Brush RedBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        private int graphicDelay;
        public void DisplayGraphic(int index,int anotherIndex)
        {
            Font arial16 = new Font("Arial", numberOfPixel/3);




            g.FillRectangle(BlackBrush, index * numberOfPixel, 0, numberOfPixel, max_value);
            g.FillRectangle(BlackBrush, anotherIndex * numberOfPixel, 0, numberOfPixel, max_value);

            g.FillRectangle(BlackBrush, index * numberOfPixel, max_value - arrayOfNumber[index], numberOfPixel, max_value);

            g.FillRectangle(BlackBrush, anotherIndex * numberOfPixel, max_value - arrayOfNumber[anotherIndex], numberOfPixel, max_value);
            if (arrayOfNumber[index] > arrayOfNumber[anotherIndex])
            {
                g.FillRectangle(GreenBrush, index * numberOfPixel, max_value - arrayOfNumber[index], numberOfPixel - 1, max_value - 1);
                g.FillRectangle(RedBrush, anotherIndex * numberOfPixel, max_value - arrayOfNumber[anotherIndex], numberOfPixel - 1, max_value - 1);
            }
            else
            {
                g.FillRectangle(RedBrush, index * numberOfPixel, max_value - arrayOfNumber[index], numberOfPixel - 1, max_value - 1);
                g.FillRectangle(GreenBrush, anotherIndex * numberOfPixel, max_value - arrayOfNumber[anotherIndex], numberOfPixel - 1, max_value - 1);
            }

            g.DrawString(arrayOfNumber[index].ToString(), arial16, new System.Drawing.SolidBrush(System.Drawing.Color.White), index*numberOfPixel, max_value-arrayOfNumber[index]);
            g.DrawString(arrayOfNumber[anotherIndex].ToString(), arial16, new System.Drawing.SolidBrush(System.Drawing.Color.White), anotherIndex*numberOfPixel, max_value-arrayOfNumber[anotherIndex]);
        }

        public void DoWork(int[] arrayOfNumber_in, Graphics g_in, int max_value_in,float numberOfPixel_in,int graphicDelay_in)
        {
            
            this.arrayOfNumber = arrayOfNumber_in;
            this.g = g_in;
            this.max_value = max_value_in;
            numberOfPixel = numberOfPixel_in;
            graphicDelay = graphicDelay_in;
            while (!_sorted)
            {
                for (int i = 0; i < arrayOfNumber.Count() - 1; i++)
                {
                    if (arrayOfNumber[i] > arrayOfNumber[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }
                _sorted = IsSorted();
            }
        }

        private bool IsSorted()
        {
            for (int i = 0; i < arrayOfNumber.Count()-1; i++)
            {
                if (this.arrayOfNumber[i] > this.arrayOfNumber[i + 1]) return false;
            }
            return true;
        }
        private void Swap(int i,int p)
        {

            int temp = arrayOfNumber[i];
            arrayOfNumber[i] = arrayOfNumber[i + 1];
            arrayOfNumber[i + 1] = temp;
            DisplayGraphic(i, p);
            System.Threading.Thread.Sleep(graphicDelay);
            g.FillRectangle(WhiteBrush, i * numberOfPixel, max_value - arrayOfNumber[i], numberOfPixel - 1, max_value - 1);
            g.FillRectangle(WhiteBrush, p * numberOfPixel, max_value - arrayOfNumber[p], numberOfPixel - 1, max_value - 1);
        }
    }
}
