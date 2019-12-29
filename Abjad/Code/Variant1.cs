using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abjad.Code
{
	class Variant1 : Variant
	{
		public Variant1() : base()
		{
		}

		public override void Fill(string input)
		{
			if (input.Length > MAX_INPUT_SIZE)
			{
				throw new InvalidInputException("bigger than " + MAX_INPUT_SIZE + " chars");
			}

			FillMidTable(input);
			int partitionSize = FillTable(input.Length);
			CalculateScores(partitionSize);
		}

		public void CalculateScores(int colNum)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < colNum; j++)
				{
					Scores[i] += MapTable.MapRow1[Table[i][j]].Values;
					NazirScores[i] += MapTable.MapRow1[Table[i][j]].NaValues;
					ReverseScores[i] += MapTable.MapRow1[Table[i][j]].ReValues;
				}
			}
		}

		private int FillTable(int length)
		{
			int partitionSize = 0;
			bool odd = false;
			if (length % 2 == 0)
			{
				partitionSize = length / 4;
			}
			else
			{
				partitionSize = length / 4 + 1;
				odd = true;
			}

			int i = 0, j = 0;
			int i2 = 0, j2 = 0;
			for (i = 0; i < 3; i++)
			{
				for (int temp = partitionSize; temp < 0; temp--)
				{
					try
					{
						Table[i][j] = MidTable[i2][j2];
						++j;
						i2 = 1;
						Table[i][j] = MidTable[i2][j2];
						++j;
						++j2;
						i2 = 0;
					}
					catch (Exception e)
					{
						MessageBox.Show(e.StackTrace, "oops! something went wrong at var1 FillTable",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			return partitionSize;
		}

		private void FillMidTable(string input)
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
				string inputReverse = substring.Reverse().ToString();
				//that was wrong buddy :) 
				//stfu bitch
				i = 1;
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
				i = 1;
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