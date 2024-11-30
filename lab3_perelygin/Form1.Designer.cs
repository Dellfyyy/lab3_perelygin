namespace lab3_perelygin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(28, 99);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(329, 99);
            numericUpDown2.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DIV", "МОД", "НОД", "НОК" });
            comboBox1.Location = new Point(179, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(179, 217);
            button1.Name = "button1";
            button1.Size = new Size(121, 30);
            button1.TabIndex = 3;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 144);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(296, 58);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 68);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Операция";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 68);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 6;
            label2.Text = "Первое число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 68);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 7;
            label3.Text = "Второе число";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 259);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
