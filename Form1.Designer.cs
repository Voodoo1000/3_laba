namespace _3_laba
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Сложение", "Вычитание", "Скалярное произведение", "Векторное произведение" });
            comboBox1.Location = new Point(33, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Сложение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(190, 33);
            label1.Name = "label1";
            label1.Size = new Size(23, 35);
            label1.TabIndex = 1;
            label1.Text = "(";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(254, 41);
            label2.Name = "label2";
            label2.Size = new Size(20, 35);
            label2.TabIndex = 3;
            label2.Text = ",";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(325, 33);
            label4.Name = "label4";
            label4.Size = new Size(23, 35);
            label4.TabIndex = 4;
            label4.Text = ")";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(325, 85);
            label5.Name = "label5";
            label5.Size = new Size(23, 35);
            label5.TabIndex = 8;
            label5.Text = ")";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(254, 93);
            label6.Name = "label6";
            label6.Size = new Size(20, 35);
            label6.TabIndex = 7;
            label6.Text = ",";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(190, 85);
            label7.Name = "label7";
            label7.Size = new Size(23, 35);
            label7.TabIndex = 6;
            label7.Text = "(";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(280, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 27);
            textBox4.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(368, 9);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 11;
            label8.Text = "Длина вектора";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(368, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(368, 94);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(190, 144);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(158, 27);
            textBox7.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(74, 143);
            label9.Name = "label9";
            label9.Size = new Size(99, 28);
            label9.TabIndex = 15;
            label9.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 191);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Калькулятор векторов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
    }
}
