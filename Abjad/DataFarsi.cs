using Abjad.Code;
using System;
using System.Drawing;
using System.Windows.Forms;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace Abjad
{
	public partial class DataFarsi : Form
	{
		private const int LangNum = 32;

		public DataFarsi()
		{
			InitializeComponent();
			char[] alpha =
			{
				'ا', 'ب', 'پ', 'ت', 'ث', 'ج', 'چ', 'ح', 'خ', 'د', 'ذ', 'ر', 'ز', 'ژ', 'س', 'ش', 'ص', 'ض', 'ط', 'ظ',
				'ع', 'غ', 'ف', 'ق', 'ک', 'گ', 'ل', 'م', 'ن', 'و', 'ه', 'ی'
			};
			char[] var1 = { 'ض', 'ت', 'ص', 'ن', 'ی', 'و', 'ب', 'ذ', 'ش', 'ف', 'م', 'ط', 'ه', 'ا'};
			char[] var2 = {'ب', 'چ', 'ح', 'غ', 'ز', 'ظ', 'ط', 'ش', 'ی', 'ت', 'ع', 'ز', 'س', 'ق'};
			char[] var3 = { 'ب', 'ژ', 'ه', 'غ', 'و', 'ظ', 'ط', 'خ', 'ی', 'ث', 'م', 'ر', 'ن', 'ق'};
		

		
			int j = 0;
			for (int rowCount = 0; rowCount < tableLayoutPanel4.RowCount; rowCount++)
			{
				for (int colCount = 0; colCount < tableLayoutPanel4.ColumnCount; colCount++)
				{
					if (colCount % 2 == 0)
					{
						Control ctr = newLable(alpha[j]);
						tableLayoutPanel4.Controls.Add(ctr, colCount, rowCount);
					}
					else
					{
						Control ctr = newIntLable(alpha[j]);
						tableLayoutPanel4.Controls.Add(ctr, colCount, rowCount);
						j++;
					}
				}
			}

			Char current;
			for (int colCount = 0; colCount < tableLayoutPanel1.ColumnCount; colCount++)
			{
				
				tableLayoutPanel1.Controls.Add(newLable(var1[colCount]), colCount, 0);
				tableLayoutPanel2.Controls.Add(newLable(var2[colCount]), colCount, 0);
				tableLayoutPanel3.Controls.Add(newLable(var3[colCount]), colCount, 0);
				current = MapTable.MapRow1[var1[colCount]].NaCharacter;
				tableLayoutPanel1.Controls.Add(newLable(current), colCount, 1);
				current = MapTable.MapRow2[var2[colCount]].NaCharacter;
				tableLayoutPanel2.Controls.Add(newLable(current), colCount, 1);
				current = MapTable.MapRow3[var3[colCount]].NaCharacter;
				tableLayoutPanel3.Controls.Add(newLable(current), colCount, 1);
				current = MapTable.MapRow1[var1[colCount]].ReCharacter;
				tableLayoutPanel1.Controls.Add(newLable(current), colCount, 2);
				current = MapTable.MapRow2[var2[colCount]].ReCharacter;
				tableLayoutPanel2.Controls.Add(newLable(current), colCount, 2);
				current = MapTable.MapRow3[var3[colCount]].ReCharacter;
				tableLayoutPanel3.Controls.Add(newLable(current), colCount, 2);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private Label newLable(char current)
		{
			Label text = new Label();
			text.TextAlign = ContentAlignment.MiddleCenter;
			text.Text = current.ToString();
			return text;
		}

		private Label newIntLable(char current)
		{
			Label text = new Label();
			text.TextAlign = ContentAlignment.MiddleCenter;
			text.Text = MapTable.MapScore[current].ToString();
			return text;
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void DataFarsi_Load(object sender, EventArgs e)
		{

		}
	}
}