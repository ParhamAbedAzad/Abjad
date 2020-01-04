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
			AlignCenterAll();
		}

	

		private void button1_Click_1(object sender, EventArgs e)
		{
            
			try
			{
				String input = checkAndTrimInput();
				Variant1 variant1 = new Variant1();
				Variant2 variant2 = new Variant2();
				Variant3 variant3 = new Variant3();
				variant1.Fill(input);
				variant2.Fill(input);
				variant3.Fill(input);
				UpdateTextBoxes(variant1,variant2,variant3);
				AlignCenterAll();
				//string outp = variant1.ToString() + "\n" + variant2.ToString() + "\n" + variant3.ToString();
				//MessageBox.Show(outp);
				//history now, those codes are -master yoda
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
				MessageBox.Show(e2.Message, "oops! something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void UpdateTextBoxes(Variant1 variant1, Variant2 variant2, Variant3 variant3)
		{
			richTextBox2.Text = variant1.Scores[0].ToString();
			richTextBox3.Text = variant1.Scores[1].ToString();
			richTextBox4.Text = variant1.Scores[2].ToString();
			richTextBox5.Text = variant1.Scores[3].ToString();

			richTextBox6.Text = variant1.NazirScores[0].ToString();
			richTextBox7.Text = variant1.NazirScores[1].ToString();
			richTextBox8.Text = variant1.NazirScores[2].ToString();
			richTextBox9.Text = variant1.NazirScores[3].ToString();

			richTextBox10.Text = variant1.ReverseScores[0].ToString();
			richTextBox11.Text = variant1.ReverseScores[1].ToString();
			richTextBox12.Text = variant1.ReverseScores[2].ToString();
			richTextBox13.Text = variant1.ReverseScores[3].ToString();
			
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
			if (input == PLACE_HOLDER)
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

		private void AlignCenterAll()
		{
			{
				richTextBox2.SelectAll();
				richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox2.DeselectAll();

				richTextBox3.SelectAll();
				richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox3.DeselectAll();

				richTextBox4.SelectAll();
				richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox4.DeselectAll();

				richTextBox5.SelectAll();
				richTextBox5.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox5.DeselectAll();
			}
			{
				richTextBox6.SelectAll();
				richTextBox6.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox6.DeselectAll();

				richTextBox7.SelectAll();
				richTextBox7.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox7.DeselectAll();

				richTextBox8.SelectAll();
				richTextBox8.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox8.DeselectAll();

				richTextBox9.SelectAll();
				richTextBox9.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox9.DeselectAll();
			}
			{
				richTextBox10.SelectAll();
				richTextBox10.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox10.DeselectAll();
				richTextBox11.SelectAll();
				richTextBox11.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox11.DeselectAll();
				richTextBox12.SelectAll();
				richTextBox12.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox12.DeselectAll();
				richTextBox13.SelectAll();
				richTextBox13.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox13.DeselectAll();
			}
		}

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.Show();

        }
    }
}