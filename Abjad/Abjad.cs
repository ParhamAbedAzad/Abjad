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
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		private static String anal1 ="";
		private static String anal2 = "";
		private static String anal3 = "";
		private Analysis analysis = new Analysis("");
#if (DEBUG || Release)
		Data data = new Data();
		private const string PLACE_HOLDER = "enter text here...";
#elif (ReleaseFarsi)
		private DataFarsi data = new DataFarsi();

		private const string PLACE_HOLDER = "متن را اینجا وارد کنید ...";
#endif

		public AbjadMainForm()
		{
			InitializeComponent();
#if (DEBUG || Release)
			richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
#elif (ReleaseFarsi)
			richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
#endif
			AlignCenterAll();
		}

		private void fill_anal(Variant1 variant1 , Variant2 variant2 , Variant3 variant3)
		{
			//TODO sth
			for (int i = 0; i < 500; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					anal1 += "  "  +  variant1.MidTable[j][i].ToString();
				}

				anal1 += '\n';
			}
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				ResetTextBoxes();
				AlignCenterAll();
				String input = checkAndTrimInput();
				Variant1 variant1 = new Variant1();
				Variant2 variant2 = new Variant2();
				Variant3 variant3 = new Variant3();
				variant1.Fill(input);
				variant2.Fill(input);
				variant3.Fill(input);
				UpdateTextBoxes(variant1, variant2, variant3);
				AlignCenterAll();
				//fill_anal(variant1,variant2,variant3);
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
					MessageBox.Show(e3.Message);
				//throw;
				//ytf u throw exception to close the entire fucking app after small error ? 
			}
		}

		private void UpdateTextBoxes(Variant1 variant1, Variant2 variant2, Variant3 variant3)
		{
			//var1
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
			//var2
			richTextBox25.Text = variant2.Scores[0].ToString();
			richTextBox22.Text = variant2.Scores[1].ToString();
			richTextBox19.Text = variant2.Scores[2].ToString();
			richTextBox16.Text = variant2.Scores[3].ToString();
			richTextBox24.Text = variant2.NazirScores[0].ToString();
			richTextBox21.Text = variant2.NazirScores[1].ToString();
			richTextBox18.Text = variant2.NazirScores[2].ToString();
			richTextBox15.Text = variant2.NazirScores[3].ToString();
			richTextBox23.Text = variant2.ReverseScores[0].ToString();
			richTextBox20.Text = variant2.ReverseScores[1].ToString();
			richTextBox17.Text = variant2.ReverseScores[2].ToString();
			richTextBox14.Text = variant2.ReverseScores[3].ToString();
			//var3
			richTextBox37.Text = variant3.Scores[0].ToString();
			richTextBox34.Text = variant3.Scores[1].ToString();
			richTextBox31.Text = variant3.Scores[2].ToString();
			richTextBox28.Text = variant3.Scores[3].ToString();
			richTextBox36.Text = variant3.NazirScores[0].ToString();
			richTextBox33.Text = variant3.NazirScores[1].ToString();
			richTextBox30.Text = variant3.NazirScores[2].ToString();
			richTextBox27.Text = variant3.NazirScores[3].ToString();
			richTextBox35.Text = variant3.ReverseScores[0].ToString();
			richTextBox32.Text = variant3.ReverseScores[1].ToString();
			richTextBox29.Text = variant3.ReverseScores[2].ToString();
			richTextBox26.Text = variant3.ReverseScores[3].ToString();
		}

		private void ResetTextBoxes()
		{
			//var1
			richTextBox2.Text = "0";
			richTextBox3.Text = "0";
			richTextBox4.Text = "0";
			richTextBox5.Text = "0";
			richTextBox6.Text = "0";
			richTextBox7.Text = "0";
			richTextBox8.Text = "0";
			richTextBox9.Text = "0";
			richTextBox10.Text = "0";
			richTextBox11.Text = "0";
			richTextBox12.Text = "0";
			richTextBox13.Text = "0";
			//var2			  
			richTextBox25.Text = "0";
			richTextBox22.Text = "0";
			richTextBox19.Text = "0";
			richTextBox16.Text = "0";
			richTextBox24.Text = "0";
			richTextBox21.Text = "0";
			richTextBox18.Text = "0";
			richTextBox15.Text = "0";
			richTextBox23.Text = "0";
			richTextBox20.Text = "0";
			richTextBox17.Text = "0";
			richTextBox14.Text = "0";
			//var3			   
			richTextBox37.Text = "0";
			richTextBox34.Text = "0";
			richTextBox31.Text = "0";
			richTextBox28.Text = "0";
			richTextBox36.Text = "0";
			richTextBox33.Text = "0";
			richTextBox30.Text = "0";
			richTextBox27.Text = "0";
			richTextBox35.Text = "0";
			richTextBox32.Text = "0";
			richTextBox29.Text = "0";
			richTextBox26.Text = "0";
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
			string text = richTextBox1.Text;
			if (text.ToLower() == "diamond")
			{
				pictureBox1.Visible = true;
				//var t = Task.Delay(5000);
				//Cursor.Current = Cursors.WaitCursor;
				//t.Wait();
				pictureBox1.Visible = false;
				//Cursor.Current = Cursors.Default;
			}
		}

		private void RichTextBox1_Enter(object sender, EventArgs e)
		{
			string text = richTextBox1.Text;
			richTextBox1.ForeColor = Color.GhostWhite;
			if (text == PLACE_HOLDER)
			{
				richTextBox1.Text = "";
			}
		}

		private void RichTextBox1_Leave(object sender, EventArgs e)
		{
			if (richTextBox1.Text == "")
			{
				richTextBox1.Text = PLACE_HOLDER;
				richTextBox1.ForeColor = Color.LightGray;
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
			input = input.Replace("!", "");
			input = input.Replace("?", "");
			input = input.Replace(".", "");
			input = input.Replace(",", "");
			input = input.Replace(";", "");
            input = input.Replace(":", "");
            input = input.Replace(")", "");
            input = input.Replace("(", "");
            input = input.Replace("}", "");
            input = input.Replace("{", "");
            input = input.Replace("<", "");
            input = input.Replace(">", "");
            input = input.ToLower();
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
			//label3.ForeColor = Color.White;
		}

		private void label3_MouseLeave(object sender, EventArgs e)
		{
			//	label3.ForeColor = Color.FromArgb(170, 170, 170);
		}

		private void label2_MouseEnter(object sender, EventArgs e)
		{
			//	label2.ForeColor = Color.White;
		}

		private void label2_MouseLeave(object sender, EventArgs e)
		{
			//label2.ForeColor = Color.FromArgb(170, 170, 170);
		}

		private void label5_MouseEnter(object sender, EventArgs e)
		{
			//label5.ForeColor = Color.White;
		}

		private void label5_MouseLeave(object sender, EventArgs e)
		{
			//	label5.ForeColor = Color.FromArgb(170, 170, 170);
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
			{
				richTextBox14.SelectAll();
				richTextBox14.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox14.DeselectAll();
				richTextBox15.SelectAll();
				richTextBox15.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox15.DeselectAll();
				richTextBox16.SelectAll();
				richTextBox16.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox16.DeselectAll();
				richTextBox17.SelectAll();
				richTextBox17.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox17.DeselectAll();
			}
			{
				richTextBox18.SelectAll();
				richTextBox18.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox18.DeselectAll();
				richTextBox19.SelectAll();
				richTextBox19.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox19.DeselectAll();
				richTextBox20.SelectAll();
				richTextBox20.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox20.DeselectAll();
				richTextBox21.SelectAll();
				richTextBox21.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox21.DeselectAll();
			}
			{
				richTextBox22.SelectAll();
				richTextBox22.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox22.DeselectAll();
				richTextBox23.SelectAll();
				richTextBox23.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox23.DeselectAll();
				richTextBox24.SelectAll();
				richTextBox24.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox24.DeselectAll();
				richTextBox25.SelectAll();
				richTextBox25.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox25.DeselectAll();
			}
			{
				richTextBox26.SelectAll();
				richTextBox26.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox26.DeselectAll();
				richTextBox27.SelectAll();
				richTextBox27.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox27.DeselectAll();
				richTextBox28.SelectAll();
				richTextBox28.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox28.DeselectAll();
				richTextBox29.SelectAll();
				richTextBox29.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox29.DeselectAll();
			}
			{
				richTextBox30.SelectAll();
				richTextBox30.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox30.DeselectAll();
				richTextBox31.SelectAll();
				richTextBox31.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox31.DeselectAll();
				richTextBox32.SelectAll();
				richTextBox32.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox32.DeselectAll();
				richTextBox33.SelectAll();
				richTextBox33.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox33.DeselectAll();
			}
			{
				richTextBox34.SelectAll();
				richTextBox34.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox34.DeselectAll();
				richTextBox35.SelectAll();
				richTextBox35.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox35.DeselectAll();
				richTextBox36.SelectAll();
				richTextBox36.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox36.DeselectAll();
				richTextBox37.SelectAll();
				richTextBox37.SelectionAlignment = HorizontalAlignment.Center;
				richTextBox37.DeselectAll();
			}
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!data.IsDisposed) data.Show();
			else
			{
#if (DEBUG || Release)
				data = new Data();
#elif (ReleaseFarsi)
				data = new DataFarsi();
#endif
				data.Show();
			}

			//scratch that reworked it for the 3rd time now it works perfectly
		}

		private void b1enter(object sender, EventArgs e)
		{
			button1.BackColor = Color.FromArgb(44,44,44);
		}

		private void b1leave(object sender, EventArgs e)
		{
			button1.BackColor = Color.FromArgb(33,33,33);
		}

		private void b2enter(object sender, EventArgs e)
		{
			button2.BackColor = Color.FromArgb(44, 44, 44);
		}

		private void b2leave(object sender, EventArgs e)
		{
			button2.BackColor = Color.FromArgb(33,33,33);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void button3_MouseHover(object sender, EventArgs e)
		{
			button3.ForeColor = Color.FromArgb(200,200,200);
		}

		private void button3_MouseLeave(object sender, EventArgs e)
		{
			button3.ForeColor = Color.FromArgb(33,33,33);
		}

		private void button4_MouseHover(object sender, EventArgs e)
		{
			button4.ForeColor = Color.FromArgb(200, 200, 200);
		}

		private void button4_MouseLeave(object sender, EventArgs e)
		{
			button4.ForeColor = Color.FromArgb(33,33,33);
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!analysis.IsDisposed)
			{
				analysis.Dispose();
			}
			if (anal1 == "")
			{
				MessageBox.Show("please start first!", "oops! something went wrong", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				analysis = new Analysis(anal1);
				analysis.Show();
			}

		}

		private void b5enter(object sender, EventArgs e)
		{
			button5.BackColor = Color.FromArgb(44,44,44);
		}

		private void b5leave(object sender, EventArgs e)
		{
			button5.BackColor = Color.FromArgb(33,33,33);
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}