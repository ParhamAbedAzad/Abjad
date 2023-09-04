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

		public char[][] MidTable { get; set; } = new char[4][]
		{
			new char[500],
			new char[500],
			new char[500],
			new char[500],
		};

		public char[][] Table { get; set; } = new char[4][]
		{
			new char[500],
			new char[500],
			new char[500],
			new char[500],
		};

		public int[] Scores { get; set; } = new int[4];

		public char[][] MidNazirTable { get; set; } = new char[4][]
		{
			new char[500],
			new char[500],
			new char[500],
			new char[500],
		};

		public char[][] NazirTable { get; set; } = new char[4][]
		{
			new char[500],
			new char[500],
			new char[500],
			new char[500],
		};

		public int[] NazirScores { get; set; } = new int[4];

		public char[][] MidReverseTable { get; set; } = new char[4][]
		{
			new char[500],
			new char[500],
			new char[500],
			new char[500],
		};

		public char[][] ReverseTable { get; set; } = new char[4][]
		{
			new char[500],
			new char[500],
			new char[500],
			new char[500],
		};

		public int[] ReverseScores { get; set; } = new int[4];

		public virtual void Fill(string input)
		{
			throw new NotSupportedException();
		}

		public virtual void Calculate()
		{
			throw new NotSupportedException();
		}

		public override String ToString()
		{
			return this.GetType().ToString().Substring(11,8)+"\nline1:" +
			       Scores[0]
				       .ToString() +
			       "\nline2:" +
			       Scores[1]
				       .ToString() +
			       "\nline3:" +
			       Scores[2]
				       .ToString() +
			       "\nline4:" +
			       Scores[3]
				       .ToString();
			;
		}
	}
}