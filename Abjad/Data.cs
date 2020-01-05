﻿using Abjad.Code;
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
        private const int LangNum = 32;
        public Data()
        {
            InitializeComponent();
            int k = 0;

	        Char current = 'a';


            for (int rowCount=0; rowCount < tableLayoutPanel4.RowCount; rowCount++)
            {
                for (int colCount = 0;colCount < tableLayoutPanel4.ColumnCount;colCount++)
                {
                    if (colCount % 2 == 1)
                    {
                        Control ctr = newIntLable(current);
                        current++;
                        k++;
                        tableLayoutPanel4.Controls.Add(ctr, colCount, rowCount);
                        if (k >= LangNum)
                        {
                            break;
                        }
                    }
                    else
                    {
                        while (!MapTable.MapScore.ContainsKey(current))
                        {
                            current++;
                        }
                        Control ctr = newLable(current);
                        tableLayoutPanel4.Controls.Add(ctr,colCount,rowCount);
                    }
                }
            }
            Char i = 'a';

            for (int colCount = 0; colCount < tableLayoutPanel1.ColumnCount; colCount++,i++)
            {
                while (!MapTable.MapScore.ContainsKey(i))
                {
                    i++;
                }
                tableLayoutPanel1.Controls.Add(newLable(i),colCount,0);
                tableLayoutPanel2.Controls.Add(newLable(i),colCount,0);
                tableLayoutPanel3.Controls.Add(newLable(i),colCount,0);
                current = MapTable.MapRow1[i].NaCharacter;
                tableLayoutPanel1.Controls.Add(newLable(current), colCount, 1);
                current = MapTable.MapRow2[i].NaCharacter;
                tableLayoutPanel2.Controls.Add(newLable(current), colCount, 1);
                current = MapTable.MapRow3[i].NaCharacter;
                tableLayoutPanel3.Controls.Add(newLable(current), colCount, 1);
                current = MapTable.MapRow1[i].ReCharacter;
                tableLayoutPanel1.Controls.Add(newLable(current), colCount, 2);
                current = MapTable.MapRow2[i].ReCharacter;
                tableLayoutPanel2.Controls.Add(newLable(Char.ToUpper(current)), colCount, 2);
                current = MapTable.MapRow3[i].ReCharacter;
                tableLayoutPanel3.Controls.Add(newLable(Char.ToUpper(current)), colCount, 2);
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
    }
}
