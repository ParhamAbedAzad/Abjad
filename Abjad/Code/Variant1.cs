﻿using System;
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
            char currentChar;
            if (input.Length > MAX_INPUT_SIZE)
            {
                throw new InvalidInputException("bigger than " + MAX_INPUT_SIZE + " chars");
            }
            int incValue = 1;
            int i = 0;
			int j = 0; //from 0 to 3
            int length = input.Length;
			Console.WriteLine(input);

            for(int cn = 0; cn < length; cn++)
			{
                currentChar = input[cn];
                AddToTables(i, j, currentChar);
                if ((j == 3 && incValue == 1) || (j == 0 && incValue == -1))
                {
                    incValue = -1*incValue;
                    i++;
                }
                else
                {
                    j += incValue;
                }
			}
            MidTable[0] = Table[0];
            MidTable[1] = Table[3];
            Array.Reverse(MidTable[1]);
            MidTable[2] = Table[1];
            MidTable[3] = Table[2];
            Array.Reverse(MidTable[3]);
            FillScoreTables(length);
        }
        
        private void AddToTables(int i, int j,char currentChar)
        {
            Table[j][ i] = currentChar;
            ReverseTable[j][ i] = MapTable.MapRow1[currentChar].ReCharacter;
            //Scores[j] += MapTable.Map[currentChar].SmallValues;
            ReverseScores[j] += MapTable.MapRow1[currentChar].ReValues;
            
            
        }
        private void FillScoreTables(int inputLenght)
        {
            int fraction = inputLenght % 4;
            int takeLenght = inputLenght / 4 + 1;
            if (fraction == 0)
            {
                takeLenght--;
            }
            
            int i=0, j=0;
            for (int k = 0;k < 4; k++)
            {
                for (int n = 0; n < takeLenght; n++)
                {
                    Scores[k] += MapTable.MapRow1[MidTable[j][i]].Values;
                    if(j == 3)
                    {
                        j = 0;
                        i++;
                    }
                    else
                    {
                        j++;
                    }
                }
                if(fraction > 1)
                {
                    fraction--;
                }
                else if (fraction == 1)
                {
                    fraction--;
                    takeLenght--;
                }
            }
        }
        private DataTable CreateTable()
        {
            DataColumn column;
            DataTable result = new DataTable("mapTable");
            for (int i = 1; i < 5; i++)
            {
                column = new DataColumn();
                column.ColumnName = i.ToString();
                result.Columns.Add(column);
            }
            return result;
        }
    }
}
