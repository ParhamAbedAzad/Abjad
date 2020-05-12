using Abjad.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abjad
{
    public partial class Data : Form
    {
        private const int LangNum = 27;
        public Data()
        {
            InitializeComponent();
			char[] alpha =
			{
				'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','@','`'
			};
			char[] var1 = { 'a', 'e', 'i', 'm', 'q', 'u', 'y', 'b', 'f', 'j', 'n', 'r', 'v','z'};
			char[] var2 = { 'a', 'u', 'b', 'v', 'h', 't', 'g', 's', 'i', 'm', 'j', 'n', 'p','z'};//dummy 
			char[] var3 = { 'a', 'x', 'b', 'w', 'e', 't', 'f', 's', 'i', 'p', 'j', 'o', 'm','z'};//dummy

			int j = 0;
			for (int rowCount=0; rowCount < tableLayoutPanel4.RowCount; rowCount++)
            {
                for (int colCount = 0;colCount < tableLayoutPanel4.ColumnCount;colCount++)
                {
					if (colCount % 2 == 0)
					{
						if (j > LangNum)
							break;
						Control ctr = newLable(alpha[j]);
						tableLayoutPanel4.Controls.Add(ctr, colCount, rowCount);
					}
					else
					{
						Control ctr = newIntLable(alpha[j]);
						tableLayoutPanel4.Controls.Add(ctr, colCount, rowCount);
						j++;
						if(j>LangNum)
							break;
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

		private void Data_Load(object sender, EventArgs e)
		{

		}
	}
}
