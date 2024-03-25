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
            components = new System.ComponentModel.Container();
            cmbOperation = new ComboBox();
            label1 = new Label();
            txtVectorA_x = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtVectorA_y = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtVectorB_x = new TextBox();
            txtVectorB_y = new TextBox();
            label8 = new Label();
            txtLengthA = new TextBox();
            txtLengthB = new TextBox();
            txtResult = new TextBox();
            label9 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "Сложение", "Вычитание", "Скалярное произведение", "Векторное произведение" });
            cmbOperation.Location = new Point(33, 62);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(151, 28);
            cmbOperation.TabIndex = 0;
            cmbOperation.Text = "Сложение";
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
            // txtVectorA_x
            // 
            txtVectorA_x.Location = new Point(207, 41);
            txtVectorA_x.Name = "txtVectorA_x";
            txtVectorA_x.Size = new Size(50, 27);
            txtVectorA_x.TabIndex = 2;
            txtVectorA_x.TextChanged += txtVectorA_x_TextChanged;
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
            // txtVectorA_y
            // 
            txtVectorA_y.Location = new Point(280, 41);
            txtVectorA_y.Name = "txtVectorA_y";
            txtVectorA_y.Size = new Size(50, 27);
            txtVectorA_y.TabIndex = 5;
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
            // txtVectorB_x
            // 
            txtVectorB_x.Location = new Point(207, 93);
            txtVectorB_x.Name = "txtVectorB_x";
            txtVectorB_x.Size = new Size(50, 27);
            txtVectorB_x.TabIndex = 9;
            // 
            // txtVectorB_y
            // 
            txtVectorB_y.Location = new Point(280, 93);
            txtVectorB_y.Name = "txtVectorB_y";
            txtVectorB_y.Size = new Size(50, 27);
            txtVectorB_y.TabIndex = 10;
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
            // txtLengthA
            // 
            txtLengthA.Location = new Point(368, 41);
            txtLengthA.Name = "txtLengthA";
            txtLengthA.Size = new Size(125, 27);
            txtLengthA.TabIndex = 12;
            // 
            // txtLengthB
            // 
            txtLengthB.Location = new Point(368, 94);
            txtLengthB.Name = "txtLengthB";
            txtLengthB.Size = new Size(125, 27);
            txtLengthB.TabIndex = 13;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(190, 144);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(158, 27);
            txtResult.TabIndex = 14;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 191);
            Controls.Add(label9);
            Controls.Add(txtResult);
            Controls.Add(txtLengthB);
            Controls.Add(txtLengthA);
            Controls.Add(label8);
            Controls.Add(txtVectorB_y);
            Controls.Add(txtVectorB_x);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtVectorA_y);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtVectorA_x);
            Controls.Add(label1);
            Controls.Add(cmbOperation);
            Name = "Form1";
            Text = "Калькулятор векторов";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperation;
        private Label label1;
        private TextBox txtVectorA_x;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtVectorA_y;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtVectorB_x;
        private TextBox txtVectorB_y;
        private Label label8;
        private TextBox txtLengthA;
        private TextBox txtLengthB;
        private TextBox txtResult;
        private Label label9;
        private ErrorProvider errorProvider1;
    }
}
