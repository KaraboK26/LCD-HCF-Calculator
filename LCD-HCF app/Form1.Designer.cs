namespace LCD_HCF_app
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHCFresult = new System.Windows.Forms.TextBox();
            this.txtHCFnum1 = new System.Windows.Forms.TextBox();
            this.txtHCFnum2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHCF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLCDResult = new System.Windows.Forms.TextBox();
            this.txtLCDnum2 = new System.Windows.Forms.TextBox();
            this.txtLCDnum1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLCD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLCDclear = new System.Windows.Forms.Button();
            this.btnHCFclear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 613);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnHCFclear);
            this.groupBox2.Controls.Add(this.txtHCFresult);
            this.groupBox2.Controls.Add(this.txtHCFnum1);
            this.groupBox2.Controls.Add(this.txtHCFnum2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnHCF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(709, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 580);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Highest Common Factor";
            // 
            // txtHCFresult
            // 
            this.txtHCFresult.Location = new System.Drawing.Point(228, 353);
            this.txtHCFresult.Name = "txtHCFresult";
            this.txtHCFresult.Size = new System.Drawing.Size(155, 30);
            this.txtHCFresult.TabIndex = 7;
            // 
            // txtHCFnum1
            // 
            this.txtHCFnum1.Location = new System.Drawing.Point(167, 171);
            this.txtHCFnum1.Name = "txtHCFnum1";
            this.txtHCFnum1.Size = new System.Drawing.Size(100, 30);
            this.txtHCFnum1.TabIndex = 6;
            // 
            // txtHCFnum2
            // 
            this.txtHCFnum2.Location = new System.Drawing.Point(167, 254);
            this.txtHCFnum2.Name = "txtHCFnum2";
            this.txtHCFnum2.Size = new System.Drawing.Size(100, 30);
            this.txtHCFnum2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Please enter two numbers: ";
            // 
            // btnHCF
            // 
            this.btnHCF.Location = new System.Drawing.Point(228, 449);
            this.btnHCF.Name = "btnHCF";
            this.btnHCF.Size = new System.Drawing.Size(155, 48);
            this.btnHCF.TabIndex = 3;
            this.btnHCF.Text = "Calculate";
            this.btnHCF.UseVisualStyleBackColor = true;
            this.btnHCF.Click += new System.EventHandler(this.btnHCF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number 2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number 1: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLCDclear);
            this.groupBox1.Controls.Add(this.txtLCDResult);
            this.groupBox1.Controls.Add(this.txtLCDnum2);
            this.groupBox1.Controls.Add(this.txtLCDnum1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLCD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lowest Common Denominator";
            // 
            // txtLCDResult
            // 
            this.txtLCDResult.Location = new System.Drawing.Point(204, 353);
            this.txtLCDResult.Name = "txtLCDResult";
            this.txtLCDResult.Size = new System.Drawing.Size(155, 30);
            this.txtLCDResult.TabIndex = 6;
            this.txtLCDResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLCDnum2
            // 
            this.txtLCDnum2.Location = new System.Drawing.Point(171, 257);
            this.txtLCDnum2.Name = "txtLCDnum2";
            this.txtLCDnum2.Size = new System.Drawing.Size(100, 30);
            this.txtLCDnum2.TabIndex = 5;
            // 
            // txtLCDnum1
            // 
            this.txtLCDnum1.Location = new System.Drawing.Point(171, 173);
            this.txtLCDnum1.Name = "txtLCDnum1";
            this.txtLCDnum1.Size = new System.Drawing.Size(100, 30);
            this.txtLCDnum1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Please enter two numbers: ";
            // 
            // btnLCD
            // 
            this.btnLCD.Location = new System.Drawing.Point(204, 449);
            this.btnLCD.Name = "btnLCD";
            this.btnLCD.Size = new System.Drawing.Size(155, 48);
            this.btnLCD.TabIndex = 2;
            this.btnLCD.Text = "Calculate";
            this.btnLCD.UseVisualStyleBackColor = true;
            this.btnLCD.Click += new System.EventHandler(this.btnLCD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number 2: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number 1: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "LCD/HCF Calculator";
            // 
            // btnLCDclear
            // 
            this.btnLCDclear.Location = new System.Drawing.Point(518, 29);
            this.btnLCDclear.Name = "btnLCDclear";
            this.btnLCDclear.Size = new System.Drawing.Size(105, 37);
            this.btnLCDclear.TabIndex = 7;
            this.btnLCDclear.Text = "Clear";
            this.btnLCDclear.UseVisualStyleBackColor = true;
            this.btnLCDclear.Click += new System.EventHandler(this.btnLCDclear_Click);
            // 
            // btnHCFclear
            // 
            this.btnHCFclear.Location = new System.Drawing.Point(482, 29);
            this.btnHCFclear.Name = "btnHCFclear";
            this.btnHCFclear.Size = new System.Drawing.Size(105, 37);
            this.btnHCFclear.TabIndex = 8;
            this.btnHCFclear.Text = "Clear";
            this.btnHCFclear.UseVisualStyleBackColor = true;
            this.btnHCFclear.Click += new System.EventHandler(this.btnHCFclear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Result: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "LCD/HCF Calculator";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHCFresult;
        private System.Windows.Forms.TextBox txtHCFnum1;
        private System.Windows.Forms.TextBox txtHCFnum2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHCF;
        private System.Windows.Forms.TextBox txtLCDResult;
        private System.Windows.Forms.TextBox txtLCDnum2;
        private System.Windows.Forms.TextBox txtLCDnum1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLCD;
        private System.Windows.Forms.Button btnHCFclear;
        private System.Windows.Forms.Button btnLCDclear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

