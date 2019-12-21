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
            InitialDataTable = CreateTable();
            MidDataTable = CreateTable();
        }
        public override DataTable Fill(string input)
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
                    incValue = -incValue;
                    i++;
                }
                else
                {
                    j += incValue;
                }
			}

			return InitialDataTable;
			
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
        private void AddToTables(int i, int j,char currentChar)
        {
            Table[j, i] = currentChar;
            ReverseTable[j, i] = MapTable.Map[currentChar].ReCharacter;
            Scores[j] += MapTable.Map[currentChar].SmallValues;
            ReverseScores[j] += MapTable.Map[currentChar].ReSmallValues;
            
            
            DataRow row = InitialDataTable.NewRow();
            row[(j+1).ToString()] = currentChar + ", " + MapTable.Map[currentChar].SmallValues.ToString();
            InitialDataTable.Rows.Add(row);
        }
    }
}
