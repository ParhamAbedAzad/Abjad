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
		private Table mapTable;

		public char[][] MidTable { get; set; } = new char[4][];
		public char[][] Table { get; set; } = new char[4][];

        public int[] Scores { get; set; } = new int[4];
		public char[][] MidNazirTable { get; set; } = new char[4][];
		public char[][] NazirTable { get; set; } = new char[4][];
		public int[] NazirScores { get; set; } = new int[4];
        public char[][] MidReverseTable { get; set; } = new char[4][];
        public char[][] ReverseTable { get; set; } = new char[4][];
        public int[] ReverseScores { get; set; } = new int[4];
        internal Table MapTable { get; set; } = new Table();
        public DataTable MidDataTable { get; set; }
        public DataTable InitialDataTable { get; set; }
        
		public virtual DataTable Fill(string input)
        {
            throw new NotSupportedException();
        }
        public virtual void Calculate()
        {
            throw new NotSupportedException();
        }
    }
}