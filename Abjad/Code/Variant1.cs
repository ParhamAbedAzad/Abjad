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
        public override DataTable Fill(string input)
        {
			DataTable dtb1 = new DataTable("mapTable");
			DataColumn column;
			DataRow row;

			column = new DataColumn();
			column.ColumnName = "1";
			dtb1.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = "2";
			dtb1.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = "3";
			dtb1.Columns.Add(column);

			column = new DataColumn();
			column.ColumnName = "4";
			dtb1.Columns.Add(column);
			
			if (input.Length > MAX_INPUT_SIZE)
				throw new InvalidInputException("bigger than "+ MAX_INPUT_SIZE +" chars");
			
			int i = 0; //from 0 to 499
			int j = 0; //from 0 to 3
			int cn = 0;//char iteration 0 max 2000

			Console.WriteLine(input);


			
			while (i<500)
			{
				if(cn >= input.Length )
					break;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["1"] = input[cn]+ ", " + MapTable.Map[input[cn]].SmallValues.ToString() ;
				dtb1.Rows.Add(row);

				++cn;
				if (cn >= input.Length )
					break;
				++j;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["2"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);

				++cn;
				if (cn >= input.Length )
					break;
				++j;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["3"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);
				++cn;
				if (cn >= input.Length )
					break;
				++j;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["4"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);
				++cn;
				if (cn >= input.Length )
					break;
				++i;//BEWARE
				Console.WriteLine(j+ " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["4"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);
				++cn;
				if (cn >= input.Length )
					break;
				--j;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["3"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);
				++cn;
				if (cn >= input.Length )
					break;
				--j;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["2"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);
				++cn;
				if (cn >= input.Length )
					break;
				--j;
				Console.WriteLine(j + " " + i);
				Table[j, i] = input[cn];
				ReverseTable[j, i] = MapTable.Map[input[cn]].ReCharacter;
				Scores[j] += MapTable.Map[input[cn]].SmallValues;
				ReverseScores[j] += MapTable.Map[input[cn]].ReSmallValues;

				row = dtb1.NewRow();
				row["1"] = input[cn].ToString() + ", " + MapTable.Map[input[cn]].SmallValues.ToString();
				dtb1.Rows.Add(row);
				++cn;
				Console.WriteLine(j + " " + i);
				if (cn >= input.Length )
					break;
				++i;
			}

			return dtb1;
			
        }
    }
}
