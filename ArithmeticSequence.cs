using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
                  if (count <= 0)
            {
                throw new ArgumentException();
            }

            int Summ = 0;
            for (int r =0; r < count; r++)
            {
                Summ = Summ + number + add *r;
                
            }
            
            return Summ; 
        }
    }
}
