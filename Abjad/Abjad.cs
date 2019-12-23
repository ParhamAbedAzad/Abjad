﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abjad.Code;

namespace Abjad
{
    public partial class AbjadMainForm : Form
    {
        public AbjadMainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
			
        }

        private void Button1_Click(object sender, EventArgs e)
        {

		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				//insert code here!
				String input = checkAndTrimInput();

                Variant1 variant1 = new Variant1();
                Variant2 variant2 = new Variant2();
                Variant3 variant3 = new Variant3();
                


				 variant1.Fill(input);
				 variant2.Fill(input);
				 variant3.Fill(input);
                string outp = variant1.ToString() + "\n" + 
                    variant2.ToString() + "\n"  +
                    variant3.ToString() + "\n" ;
                

				MessageBox.Show(outp);
				//variant.Calculate();
				//show variant in a table
				

				
			}
			catch (InvalidInputException e1)
			{
				if (e1.Message != null)
					MessageBox.Show(e1.Message);
				else
					MessageBox.Show(e1.StackTrace);
			}
			catch (NotImplementedException)
			{
				MessageBox.Show("feature not yet implemented it will be added in future updates");
			}
			catch (Exception e3)
			{
				if (e3.Message == null)
					MessageBox.Show(e3.StackTrace,"oops! something went wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
				else
					MessageBox.Show(e3.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

        private void ComboVariant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
			
        }
        private void ComboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = (comboLang.Text == "English") ? RightToLeft.No : RightToLeft.Yes;
			
		}

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Trace: button1.Location = AddPoints(richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart),richTextBox1.Location) - button1.Size;
            
        }
        private String checkAndTrimInput()
        {
			String input = richTextBox1.Text.Replace(" ", "");
			return input;
        }
		
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			
		}
        private Point AddPoints(Point A , Point B)
        {
            return new Point(A.X + B.X, A.Y + B.Y);
        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
