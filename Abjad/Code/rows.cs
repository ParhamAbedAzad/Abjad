using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
	class Rows
	{
		private char character;
		private int smallValues;
		private int bigValues;
		private char reCharacter;
		private int reSmallValues;
		private int reBigValues;

		public char Character { get => character; set => character = value; }
		public int SmallValues { get => smallValues; set => smallValues = value; }
		public int BigValues { get => bigValues; set => bigValues = value; }
		public char ReCharacter { get => reCharacter; set => reCharacter = value; }
		public int ReSmallValues { get => reSmallValues; set => reSmallValues = value; }
		public int ReBigValues { get => reBigValues; set => reBigValues = value; }

		public Rows(char character, int smallValues, int bigValues, char reCharacter, int reSmallValues, int reBigValues)
		{
			this.Character = character;
			this.SmallValues = smallValues;
			this.BigValues = bigValues;
			this.ReCharacter = reCharacter;
			this.ReSmallValues = reSmallValues;
			this.ReBigValues = reBigValues;
		}
	}
}
