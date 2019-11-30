using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
    class Variant
    {
		public const int MAX_INPUT_SIZE = 2000;
		private char[,] table = new char[4, 500];
		private int[] scores = new int[4];
		private char[,] reverseTable = new char[4, 500];
		private int[] reverseScores = new int[4];

		private Table mapTable = new Table();

		public char[,] Table { get => table; set => table = value; }
		public int[] Scores { get => scores; set => scores = value; }
		public char[,] ReverseTable { get => reverseTable; set => reverseTable = value; }
		public int[] ReverseScores { get => reverseScores; set => reverseScores = value; }
		internal Table MapTable { get => mapTable; set => mapTable = value; }

		//(parham) use properties baka xD

		public virtual DataTable Fill(string input)
        {
            throw new NotSupportedException();
        }
        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}