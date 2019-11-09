namespace Abjad
{
    partial class Abjad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboVariant = new System.Windows.Forms.ComboBox();
			this.comboSize = new System.Windows.Forms.ComboBox();
			this.comboLang = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(199, 12);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.richTextBox1.Size = new System.Drawing.Size(824, 239);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1029, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = ":متن ورودی";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 197);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 54);
			this.button1.TabIndex = 2;
			this.button1.Text = "Do the math";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// comboVariant
			// 
			this.comboVariant.FormattingEnabled = true;
			this.comboVariant.Items.AddRange(new object[] {
            "Variant1",
            "Variant2",
            "Variant3"});
			this.comboVariant.Location = new System.Drawing.Point(16, 14);
			this.comboVariant.Margin = new System.Windows.Forms.Padding(4);
			this.comboVariant.Name = "comboVariant";
			this.comboVariant.Size = new System.Drawing.Size(156, 24);
			this.comboVariant.TabIndex = 3;
			this.comboVariant.Text = "Choose Variant";
			this.comboVariant.SelectedIndexChanged += new System.EventHandler(this.ComboVariant_SelectedIndexChanged);
			// 
			// comboSize
			// 
			this.comboSize.FormattingEnabled = true;
			this.comboSize.Items.AddRange(new object[] {
            "Big",
            "Small"});
			this.comboSize.Location = new System.Drawing.Point(16, 134);
			this.comboSize.Margin = new System.Windows.Forms.Padding(4);
			this.comboSize.Name = "comboSize";
			this.comboSize.Size = new System.Drawing.Size(156, 24);
			this.comboSize.TabIndex = 4;
			this.comboSize.Text = "Choose Size";
			this.comboSize.SelectedIndexChanged += new System.EventHandler(this.ComboSize_SelectedIndexChanged);
			// 
			// comboLang
			// 
			this.comboLang.FormattingEnabled = true;
			this.comboLang.Items.AddRange(new object[] {
            "English",
            "Persian"});
			this.comboLang.Location = new System.Drawing.Point(16, 74);
			this.comboLang.Margin = new System.Windows.Forms.Padding(4);
			this.comboLang.Name = "comboLang";
			this.comboLang.Size = new System.Drawing.Size(156, 24);
			this.comboLang.TabIndex = 5;
			this.comboLang.Text = "Choose Language";
			this.comboLang.SelectedIndexChanged += new System.EventHandler(this.ComboLang_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(386, 256);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(671, 294);
			this.tabControl1.TabIndex = 6;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.hScrollBar1);
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(663, 265);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "نتیجه";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(0, 247);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(664, 18);
			this.hScrollBar1.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 238);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(663, 265);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "محاسبات";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Abjad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1121, 556);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.comboLang);
			this.Controls.Add(this.comboSize);
			this.Controls.Add(this.comboVariant);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Abjad";
			this.Text = "Abjad";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboVariant;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboLang;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

