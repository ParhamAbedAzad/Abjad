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

		private void CalculateScores(int colNum)
		{
			int vHolder = 0;
			int nvHolder = 0;
			int rvHolder = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j <= colNum; j++)
				{
					vHolder = 0;
					nvHolder = 0;
					rvHolder = 0;
					if (Table[i][j]==0)
					{
						vHolder = 0;
					}
					else
					{
						try
						{

							vHolder = MapTable.MapRow1[Table[i][j]].Values;
							nvHolder = MapTable.MapRow1[Table[i][j]].NaValues;
							rvHolder = MapTable.MapRow1[Table[i][j]].ReValues;
						}
						catch (Exception e)
						{
							throw new Exception("value \""+Table[i][j]+"\" not present in Dictionary");
						}
					}
					
					Scores[i] += vHolder;
					NazirScores[i] += nvHolder;
					ReverseScores[i] += rvHolder;

				}
			}
		}

		private int FillTable(int length)
		{
			int fraction = 0;
			int partitionSize = 0;
			bool odd = false;
			if (length % 4 == 0)
			{
				partitionSize = length / 4;
			}
			else
			{
				fraction = length % 4;
				partitionSize = length / 4 + 1;
				odd = true;
			}

			int i,j;
			int i2 = 0, j2 = 0;
			for (i = 0; i < 4; i++)
			{
				j = 0;
				for (int temp = 0; temp < partitionSize; temp++)
				{
					try
					{
						Table[i][j] = MidTable[i2][j2];
						j++;
						if (i2 == 1)
						{
							i2 = 0;
							j2++;
						}
						else
						{
							i2 = 1;
						}
					}
					catch (Exception e)
					{
						MessageBox.Show(e.StackTrace, "oops! something went wrong at var1 FillTable",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

				if (fraction > 1)
				{
					fraction--;
				}
				else if(fraction==1)
				{
					fraction--;
					partitionSize--;
				}
			}

			return partitionSize;
		}

		private void FillMidTable(string input)
		{
			char currentChar;
			int length = input.Length;
			int middle = length / 2 + (length % 2); 
			
				int i = 0;
				int j = 0;
				for (int cn = 0; cn < middle; cn++)
				{
					currentChar = input[cn];
					MidTable[i][j] = currentChar;
					++j;
				}

				string substring = input.Substring(middle);
				string inputReverse = new string(substring.Reverse().ToArray());
				//that was wrong buddy :) 
				//stfu bitch
				//yours didn't work too bro :\
				i = 1;
				j = 0;
				for (int cn = 0; cn < length / 2; cn++)
				{
					currentChar = inputReverse[cn];
					MidTable[i][j] = currentChar;
					++j;
				}
			
			
		}
	}
}