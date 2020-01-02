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

	public partial class AbjadMainForm : Form
	{
		private const string PLACE_HOLDER = "enter text here...";
		public AbjadMainForm()
		{
			InitializeComponent();
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
				string outp = variant1.ToString() + "\n" + variant2.ToString() + "\n" + variant3.ToString();
				richTextBox2.Text = variant1.Scores[0].ToString();
				richTextBox3.Text = variant1.Scores[1].ToString();
				richTextBox4.Text = variant1.Scores[2].ToString();
				richTextBox5.Text = variant1.Scores[3].ToString();
				MessageBox.Show(outp);
				//variant.Calculate();
				//show variant in a table
			}
			catch (InvalidInputException e1)
			{
				MessageBox.Show(e1.Message ?? e1.StackTrace);
			}
			catch (NotImplementedException)
			{
				MessageBox.Show("feature not yet implemented it will be added in future updates");
			}
			catch (NoNullAllowedException e2)
			{
				MessageBox.Show(e2.Message, "oops! something went wrong", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
			catch (Exception e3)
			{
				if (e3.Message == null)
					MessageBox.Show(e3.StackTrace, "oops! something went wrong", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				else
					MessageBox.Show(e3.Message + "\n" + e3.StackTrace, "Error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				//throw;
				//ytf u throw exception to close the entire fucking app after small error ? 
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

		private void RichTextBox1_TextChanged(object sender, EventArgs e)
		{
			// Trace: button1.Location = AddPoints(richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart),richTextBox1.Location) - button1.Size;
		}
		private void RichTextBox1_Enter(object sender, EventArgs e)
		{
			richTextBox1.ForeColor = Color.White;
			
			if (richTextBox1.Text == PLACE_HOLDER)
			{
				richTextBox1.Text = "";
			}
		}
	
		private void RichTextBox1_Leave(object sender, EventArgs e)
		{
			
			if (richTextBox1.Text == "")
			{
				richTextBox1.Text = PLACE_HOLDER;
				richTextBox1.ForeColor = Color.Gray;
			}
		}

		private String checkAndTrimInput()
		{
			String input = richTextBox1.Text;
			if (input == PLACE_HOLDER )
			{
				throw new NoNullAllowedException("enter the text first");
			}
			input = richTextBox1.Text.Replace(" ", "");
			input = input.Replace("\n", "");
			if (input == "")
			{
				throw new NoNullAllowedException("enter the text first (only white space and Enter are not text)");
			}
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

		private Point AddPoints(Point A, Point B)
		{
			return new Point(A.X + B.X, A.Y + B.Y);
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label3_MouseEnter(object sender, EventArgs e)
		{
			label3.ForeColor = Color.White;
		}

		private void label3_MouseLeave(object sender, EventArgs e)
		{
			label3.ForeColor = Color.FromArgb(170, 170, 170);
		}
		private void label2_MouseEnter(object sender, EventArgs e)
		{
			label2.ForeColor = Color.White;
		}

		private void label2_MouseLeave(object sender, EventArgs e)
		{
			label2.ForeColor = Color.FromArgb(170, 170, 170);
		}
		private void label5_MouseEnter(object sender, EventArgs e)
		{
			label5.ForeColor = Color.White;
		}

		private void label5_MouseLeave(object sender, EventArgs e)
		{
			label5.ForeColor = Color.FromArgb(170, 170, 170);
		}

		
	}
}