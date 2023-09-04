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
	public partial class Analysis : Form
	{
		private String anal;
		public Analysis(String anal)
		{
			this.anal = anal;
			InitializeComponent();
		}

		private void Analysis_Load(object sender, EventArgs e)
		{
			richTextBox1.Text = anal;
		}
	}
}
