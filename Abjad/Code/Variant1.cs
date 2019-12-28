using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abjad.Code
{
	class Variant1 : Variant
	{
		public Variant1() : base()
		{
		}

		public void Fill(string input)
		{
			if (input.Length > MAX_INPUT_SIZE)
			{
				throw new InvalidInputException("bigger than " + MAX_INPUT_SIZE + " chars");
			}

			FillMidTable(input);
		}

		public void FillMidTable(string input)
		{
			char currentChar;

			int length = input.Length;
			if (length % 2 == 0) //even input length
			{
				int i = 0;
				int j = 0;

				for (int cn = 0; cn < length / 2; cn++)
				{
					currentChar = input[cn];
					MidNazirTable[i][j] = currentChar;
					++j;
				}

				string substring = input.Substring(length / 2);
				string inputReverse = (string) substring.Reverse();
				++i;
				j = 0;
				for (int cn = 0; cn < length / 2; cn++)
				{
					currentChar = input[cn];
					MidNazirTable[i][j] = currentChar;
					++j;
				}
			}
			else //odd input length
			{
				int i = 0;
				int j = 0;
				for (int cn = 0; cn < length / 2 + 1; cn++)
				{
					currentChar = input[cn];
					MidNazirTable[i][j] = currentChar;
					++j;
				}

				string substring = input.Substring(length / 2 + 1);
				string inputReverse = (string) substring.Reverse();
				++i;
				j = 0;
				for (int cn = 0; cn < length / 2; cn++)
				{
					currentChar = input[cn];
					MidNazirTable[i][j] = currentChar;
					++j;
				}
			}
		}
	}
}