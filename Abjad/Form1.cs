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
                //insert code here!
                checkInput();
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkInput()
        {
            //input should be checked here
        }
    }
}
