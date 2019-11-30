using System;
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
    public partial class Abjad : Form
    {
        public Abjad()
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
				Variant variant;
				//insert code here!
				String input = checkAndTrimInput();
				switch (comboVariant.Text)
				{
					case "Variant1":
						variant = new Variant1();
						break;
					case "Variant2":
						variant = new Variant1();
						break;
					case "Variant3":
						variant = new Variant1();
						break;
					default:
						throw new Exception("no variant selected");
				}

				DataTable dtb1;


				dtb1 = variant.Fill(input);
				string outp = "line1:" + variant.Scores[0].ToString() + "\nline2:" + 
					variant.Scores[1].ToString() + "\nline3:" + 
					variant.Scores[2].ToString() + "\nline4:" + 
					variant.Scores[3].ToString() ;

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
					MessageBox.Show(e3.StackTrace,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
