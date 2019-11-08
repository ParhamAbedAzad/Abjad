using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
    class Variant
    {
        char[,] table = new char[4, 500];
        int[] scores = new int[4];
        char[,] reverseTable = new char[4, 500];
        int[] reverseScores = new int[4];
        public virtual void Fill()
        {
            throw new NotSupportedException();
        }
        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}