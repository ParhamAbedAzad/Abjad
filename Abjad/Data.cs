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
        private const int LangNum = 26;
        public Data()
        {
            InitializeComponent();
            int k = 0;
            Char current = 'A';
            Label text = new Label();
            for (int rowCount=0; rowCount < tableLayoutPanel4.RowCount; rowCount++)
            {
                for (int colCount = 0;colCount < tableLayoutPanel4.ColumnCount;colCount++)
                {
                    if (colCount % 2 == 1)
                    {
                        text = new Label();
                        text.TextAlign = ContentAlignment.MiddleCenter;
                        text.Text = MapTable.MapScore[Char.ToLower(current)].ToString();
                        current++;
                        k++;
                        Control ctr = text;
                        tableLayoutPanel4.Controls.Add(ctr, colCount, rowCount);
                        if (k >= LangNum)
                        {
                            break;
                        }
                    }
                    else
                    {

                        text = new Label();
                        text.TextAlign = ContentAlignment.MiddleCenter;
                        text.Text = current.ToString();
                        Control ctr = text;
                        tableLayoutPanel4.Controls.Add(ctr,colCount,rowCount);
                    }
                }
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
    }
}
