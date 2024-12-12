namespace Quiz3
{
    partial class Fraction
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_Top = new System.Windows.Forms.TextBox();
            this.first_Bottom = new System.Windows.Forms.TextBox();
            this.second_Top = new System.Windows.Forms.TextBox();
            this.second_Bottom = new System.Windows.Forms.TextBox();
            this.result_Top = new System.Windows.Forms.TextBox();
            this.result_Bottom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.subtractButton = new System.Windows.Forms.RadioButton();
            this.multiplyButton = new System.Windows.Forms.RadioButton();
            this.divideButton = new System.Windows.Forms.RadioButton();
            this.addButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // first_Top
            // 
            this.first_Top.Location = new System.Drawing.Point(27, 184);
            this.first_Top.Name = "first_Top";
            this.first_Top.Size = new System.Drawing.Size(46, 28);
            this.first_Top.TabIndex = 3;
            this.first_Top.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // first_Bottom
            // 
            this.first_Bottom.Location = new System.Drawing.Point(102, 184);
            this.first_Bottom.Name = "first_Bottom";
            this.first_Bottom.Size = new System.Drawing.Size(46, 28);
            this.first_Bottom.TabIndex = 4;
            // 
            // second_Top
            // 
            this.second_Top.Location = new System.Drawing.Point(349, 187);
            this.second_Top.Name = "second_Top";
            this.second_Top.Size = new System.Drawing.Size(46, 28);
            this.second_Top.TabIndex = 5;
            // 
            // second_Bottom
            // 
            this.second_Bottom.Location = new System.Drawing.Point(424, 187);
            this.second_Bottom.Name = "second_Bottom";
            this.second_Bottom.Size = new System.Drawing.Size(46, 28);
            this.second_Bottom.TabIndex = 6;
            // 
            // result_Top
            // 
            this.result_Top.Location = new System.Drawing.Point(580, 191);
            this.result_Top.Name = "result_Top";
            this.result_Top.Size = new System.Drawing.Size(46, 28);
            this.result_Top.TabIndex = 7;
            // 
            // result_Bottom
            // 
            this.result_Bottom.Location = new System.Drawing.Point(655, 191);
            this.result_Bottom.Name = "result_Bottom";
            this.result_Bottom.Size = new System.Drawing.Size(46, 28);
            this.result_Bottom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "/";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "=";
            // 
            // addButton
            // 
            this.addButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.Location = new System.Drawing.Point(186, 69);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(27, 28);
            this.addButton.TabIndex = 13;
            this.addButton.TabStop = true;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // subtractButton
            // 
            this.subtractButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.subtractButton.AutoSize = true;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtractButton.Location = new System.Drawing.Point(186, 129);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(27, 28);
            this.subtractButton.TabIndex = 14;
            this.subtractButton.TabStop = true;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplyButton.Location = new System.Drawing.Point(186, 193);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(27, 28);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.TabStop = true;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.divideButton.AutoSize = true;
            this.divideButton.Location = new System.Drawing.Point(186, 259);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(27, 28);
            this.divideButton.TabIndex = 16;
            this.divideButton.TabStop = true;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // addButton1
            // 
            this.addButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addButton1.Location = new System.Drawing.Point(312, 356);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(254, 37);
            this.addButton1.TabIndex = 17;
            this.addButton1.Text = "Perform Operation ";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_Bottom);
            this.Controls.Add(this.result_Top);
            this.Controls.Add(this.second_Bottom);
            this.Controls.Add(this.second_Top);
            this.Controls.Add(this.first_Bottom);
            this.Controls.Add(this.first_Top);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fraction";
            this.Text = "Fraction Four Operations";
            this.Load += new System.EventHandler(this.Fraction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_Top;
        private System.Windows.Forms.TextBox first_Bottom;
        private System.Windows.Forms.TextBox second_Top;
        private System.Windows.Forms.TextBox second_Bottom;
        private System.Windows.Forms.TextBox result_Top;
        private System.Windows.Forms.TextBox result_Bottom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton subtractButton;
        private System.Windows.Forms.RadioButton multiplyButton;
        private System.Windows.Forms.RadioButton divideButton;
        private System.Windows.Forms.Button addButton1;
    }
}

