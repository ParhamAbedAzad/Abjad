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
			String parham;
			string amir_created;
            String parham_Created;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Variant variant;
                //insert code here!
                checkInput();
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
                        throw new Exception();
                }
                variant.Fill(richTextBox1.Text);//(amir): add the func in variant1 then delete these comments
                variant.Calculate();
                //show variant in a table
            }
            catch(InvalidInputException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("feature not yet implemented it will be added in future updates");
            }
            catch (Exception)
            {
                MessageBox.Show("oops! something went wrong");
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
        private void checkInput()
        {
            //input should be checked here
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
